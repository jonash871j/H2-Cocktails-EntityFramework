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
            Console.WriteLine(" 1. List with cocktails");
            Console.WriteLine(" 2. Create cocktail");
            Console.WriteLine(" 3. Update cocktail");
            Console.WriteLine(" 4. Delete cocktail");
            Console.WriteLine(" 5. Search for cocktails");
            Console.WriteLine(" 6. Set default cocktails");
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
                    UpdateDrink();
                    return true;
                case ConsoleKey.D4:
                    DeleteDrink();
                    return true;
                case ConsoleKey.D5:
                    SearchDrink();
                    return true;
                case ConsoleKey.D6:
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
            Console.WriteLine("List with cocktails:");

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


        private static void UpdateDrink()
        {
            Console.Clear();
            Console.Write("Write the cocktail name: ");
            string cocktailName = Console.ReadLine();
            var cocktail = coCon.Get(cocktailName);
            if (cocktail != null)
            {
                Console.WriteLine("\r\nChoose to edit:");
                Console.WriteLine(" 1. Glass type");
                Console.WriteLine(" 2. Ingredients");
                Console.Write("\r\nYour choice: ");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.D1)
                {
                    ChangeCocktailGlassType(cocktail);
                }
                else if (key == ConsoleKey.D2)
                {
                    ChangeCocktailIngredients(cocktail);
                }
            
            }
            coCon.Update(cocktail);
            ExitCurrentMenu();
        }

        private static void ChangeCocktailGlassType(Cocktail cocktail)
        {
            Console.Clear();
            Console.WriteLine("\r\nNew Glass type:");
            Console.WriteLine(" 1. Old Fashioned");
            Console.WriteLine(" 2. Collins");
            Console.WriteLine(" 3. Martini");
            Console.WriteLine(" 4. Highball");
            Console.WriteLine(" 5. Poco Grande");
            Console.WriteLine(" 6. Flute");
            GlassType type = GetGlassType(int.Parse(Console.ReadLine()));
            cocktail.GlassType = type;
        }

        private static void ChangeCocktailIngredients(Cocktail cocktail)
        {
            Console.Clear();
            Console.WriteLine(cocktail.Name + "'s ingredients:");
            for (int i = 0; i < cocktail.IngredientDescription.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + cocktail.IngredientDescription[i].Ingredient + " : " + cocktail.IngredientDescription[i].Description);
            }
            Console.Write("\r\nWrite ingredient number to update: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number > 0 && number < cocktail.IngredientDescription.Count())
                {
                    Console.Write("New ingredient amount: ");
                    string newValue = Console.ReadLine();
                    cocktail.IngredientDescription[(number - 1)].Description = newValue;
                    Console.WriteLine("Changed ingredient amount");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void DeleteDrink()
        {
            Console.Clear();
            Console.Write("Cocktail name to delete: ");
            string toDelete = Console.ReadLine();
            if (coCon.Get(toDelete) != null)
            {
                coCon.Delete(toDelete);
                Console.WriteLine("Removed cocktail: " + toDelete);
            }
            ExitCurrentMenu();
        }

        private static void SearchDrink()
        {
            Console.Clear();
            Console.Write("Search for cocktails name: ");
            List<Cocktail> searchFor = coCon.GetBySearch(Console.ReadLine());
            Console.WriteLine("Drinks founded:\r\n");
            if (searchFor.Count > 0)
            {
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
            }
            else
            {
                Console.WriteLine("Didn't find any cocktail with that name.");
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
