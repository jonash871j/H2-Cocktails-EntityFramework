using Cocktails.Controllers;
using Cocktails.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cocktails
{
    class Program
    {
        static CocktailController coCon = new CocktailController();
        static IngredientController inCon = new IngredientController();

        // * Package Manager Console
        // EntityFrameworkCore\Add-Migration "InitialCreate"
        // EntityFrameworkCore\Update-Database

        static void Main(string[] args)
        {
            if (coCon.GetAll().Count() == 0)
            {
                Data.SetDefaultIngredients();
                Data.SetDefaultCocktails();
            }

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }


            //controller.CreateCocktail(new Cocktail { Name = "Dummy2", Glass = GlassType.Collins, Ingredients = new List<Ingredient>() { new LiquidIngredient { Name = "SomeLiquid2", MlAmount = 100 } } });


            //foreach (var c in controller.GetAllCocktails())
            //{
            //    Console.WriteLine(c.Name);
            //    Console.WriteLine(c.Glass);
            //}
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine(" 1. List with drinks");
            Console.WriteLine(" 2. Create Drink");
            Console.WriteLine(" 3. Delete Drink");
            Console.WriteLine(" 4. Search for Drink");
            Console.WriteLine(" 5. Set default cocktails");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    DrinkList();
                    return true;
                case ConsoleKey.D2:
                    CreateDrink();
                    return true;
                case ConsoleKey.D3:
                    DeleteDrink();
                    return true;
                case ConsoleKey.D4:
                    SearchDrink();
                    return true;
                case ConsoleKey.D5:
                    Data.SetDefaultCocktails();
                    Data.SetDefaultIngredients();
                    return true;
                default:
                    return false;
            }
        }
        private static void DrinkList()
        {
            Console.Clear();
            Console.WriteLine("List with drinks:");

            foreach (Cocktail item in coCon.GetAll())
            {
                Console.WriteLine("Cocktail: " + item.Name);
                Console.WriteLine("Glass used: " + item.GlassType);

                Console.WriteLine(" Ingredients:");
                foreach(IngredientDescription ingredientDescription in item.IngredientDescription)
                {
                    Ingredient ingredient = inCon.Get(ingredientDescription.Ingredient);
                    Console.WriteLine("  - " + ingredient.Name + " : " + ingredientDescription.Description);
                }
                 
                Console.WriteLine("\r\n");
            }
            ExitCurrentMenu();
        }

        private static GlassType GetGlassType(int value)
        {
            GlassType glassType = (GlassType)value;

            if (!Enum.IsDefined(typeof(GlassType), glassType))
                throw new Exception("Invalid glass");

            return glassType;
        }

        private static void CreateDrink()
        {
            Cocktail cocktail = new Cocktail();
            Console.Clear();

            try
            {
                GetCocktailNameInput();
                GetCocktailGlass();
                GetIngredientDescriptions();

                coCon.Create(cocktail);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cocktail was not created: " + ex.Message);
            }
            finally
            {
                ExitCurrentMenu();
            }
            void GetCocktailNameInput()
            {
                Console.Write("Name of drink: ");
                cocktail.Name = Console.ReadLine();

                if (string.IsNullOrEmpty(cocktail.Name))
                    throw new Exception("Name is empty");
            }
            void GetCocktailGlass()
            {
                string[] glassTypes = Enum.GetNames(typeof(GlassType));
                for (int i = 0; i < glassTypes.Length; i++)
                {
                    Console.WriteLine($" {i}. {glassTypes[i]}");
                }
                Console.WriteLine("\r\nGlass type:");
                cocktail.GlassType = GetGlassType(int.Parse(Console.ReadLine()));
            }
            void GetIngredientDescriptions()
            {
                List<Ingredient> ingredients = inCon.GetAll();

                for (int i = 0; i < ingredients.Count; i++)
                {
                    Console.WriteLine($" {i}. {ingredients[i].Name} : {ingredients[i].IngredientType.ToString()}");
                }
                Console.WriteLine("\r\nIngredient:");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine("\r\nDescription:");
                string decscription = Console.ReadLine();

                cocktail.IngredientDescription.Add(new IngredientDescription(ingredients[choice].Name, decscription));

                Console.WriteLine("Do you want more ingredients, type 'Y' ");
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Y)
                {
                    GetIngredientDescriptions();
                }
            }
        }

        private static void DeleteDrink()
        {
            Console.Clear();
            Console.Write("Drink name to delete: ");
            string toDelete = Console.ReadLine();
            if (coCon.Get(toDelete) != null)
            {
                coCon.Delete(toDelete);
                Console.WriteLine("Removed drink: " + toDelete);
            }
            ExitCurrentMenu();
        }

        private static void SearchDrink()
        {
            Console.Clear();
            Console.Write("Search for drink name: ");
            var searchFor = coCon.GetBySearch(Console.ReadLine());
            Console.WriteLine("Drinks founded:\r\n");
            foreach (Cocktail item in searchFor)
            {
                Console.WriteLine("Cocktail: " + item.Name);
                Console.WriteLine("Glass used: " + item.GlassType);

                Console.WriteLine(" Ingredients:");
                foreach (IngredientDescription ingredientDescription in item.IngredientDescription)
                {
                    Ingredient ingredient = inCon.Get(ingredientDescription.Ingredient);
                    Console.WriteLine("  - " + ingredient.Name + " : " + ingredientDescription.Description);
                }

                Console.WriteLine("\r\n");
            }
            ExitCurrentMenu();
        }

        private static void ExitCurrentMenu()
        {
            Console.WriteLine("\r\nPress any key to go back");
            Console.ReadKey();
        }
    }
}
