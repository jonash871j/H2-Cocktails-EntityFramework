using Cocktails.Controllers;
using Cocktails.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cocktails
{
    class Program
    {
        static CocktailController cocktailController = new CocktailController();
        static IngredientController ingredientController = new IngredientController();

        static int Main(string[] args)
        {
            // If there is no cocktails in the table,
            // Set default cocktails
            if (cocktailController.GetAll().Count() == 0)
            {
                SetDefaultCocktails();
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine(" 1. List with all cocktails");
                Console.WriteLine(" 2. Create cocktail");
                Console.WriteLine(" 3. Delete cocktail");
                Console.WriteLine(" 4. Search for cocktails");
                Console.WriteLine(" 5. Set default cocktails");

                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: UiShowAllCoocktails();  break;
                    case ConsoleKey.D2: UiCreateCocktail();     break;
                    case ConsoleKey.D3: UiDeleteCocktail();     break;
                    case ConsoleKey.D4: UiSearchCocktail();     break;
                    case ConsoleKey.D5: SetDefaultCocktails();  break;
                    default:                                    return 0;
                }
            }
        }
        static void UiShowAllCoocktails()
        {
            Console.Clear();
            Console.WriteLine("List with cocktails:");

            foreach (Cocktail item in cocktailController.GetAll())
            {
                UiShowCocktailDetailed(item);
            }
            UiPressAnyKeyToLeave();
        }
        static void UiCreateCocktail()
        {
            Cocktail cocktail = new Cocktail();
            Console.Clear();

            try
            {
                UiGetCocktailNameInput(cocktail);
                UiGetCocktailGlass(cocktail);
                UiGetIngredientDescriptions(cocktail);

                cocktailController.Create(cocktail);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cocktail was not created: " + ex.Message);
            }
            finally
            {
                UiPressAnyKeyToLeave();
            }
        }
        static void UiDeleteCocktail()
        {
            Console.Clear();
            Console.Write("Cocktail name to delete: ");

            try
            {
                cocktailController.Delete(Console.ReadLine());
                Console.WriteLine("Removed cocktail...");
            }
            catch
            {
                Console.WriteLine("Cocktail does not exist!");
            }

            UiPressAnyKeyToLeave();
        }
        static void UiSearchCocktail()
        {
            Console.Clear();
            Console.Write("Search for cocktails name: ");
            List<Cocktail> searchFor = cocktailController.GetBySearch(Console.ReadLine());

            Console.WriteLine("Drinks founded:\r\n");
            foreach (Cocktail cocktail in searchFor)
            {
                UiShowCocktailDetailed(cocktail);
            }
            if (searchFor.Count == 0)
            {
                Console.WriteLine("Didn't find any cocktail with that name.");
            }

            UiPressAnyKeyToLeave();
        }
        static void UiGetCocktailNameInput(Cocktail cocktail)
        {
            Console.Write("Name of drink: ");
            cocktail.Name = Console.ReadLine();

            if (string.IsNullOrEmpty(cocktail.Name))
                throw new Exception("Name is empty");
        }

        static void UiGetCocktailGlass(Cocktail cocktail)
        {
            string[] glassTypes = Enum.GetNames(typeof(GlassType));
            for (int i = 0; i < glassTypes.Length; i++)
            {
                Console.WriteLine($" {i}. {glassTypes[i]}");
            }
            Console.WriteLine("\r\nGlass type:");
            cocktail.GlassType = ConvertToGlassType(int.Parse(Console.ReadLine()));
        }
        static void UiGetIngredientDescriptions(Cocktail cocktail)
        {
            List<Ingredient> ingredients = ingredientController.GetAll();

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
                UiGetIngredientDescriptions(cocktail);
            }
        }
        static void UiShowCocktailDetailed(Cocktail cocktail)
        {
            Console.WriteLine("Cocktail: " + cocktail.Name);
            Console.WriteLine("Glass used: " + cocktail.GlassType);
            Console.WriteLine("Ingredients:");
           
            foreach (IngredientDescription ingredient in cocktail.IngredientDescription)
            {
                Console.WriteLine("  - " + ingredient.Ingredient + " : " + ingredient.Description);
            }

            Console.WriteLine();
        }
        static void UiPressAnyKeyToLeave()
        {
            Console.WriteLine("\r\nPress any key to leavy");
            Console.ReadKey();
        }

        static void SetDefaultCocktails()
        {
            Data.SetDefaultIngredients();
            Data.SetDefaultCocktails();
        }
        static GlassType ConvertToGlassType(int value)
        {
            GlassType glassType = (GlassType)value;

            if (!Enum.IsDefined(typeof(GlassType), glassType))
                throw new Exception("Invalid glass");

            return glassType;
        }

        //** Unused
        //static void UiUpdateCocktail()
        //{
        //    Console.Clear();
        //    Console.Write("Write the cocktail name: ");
        //    string cocktailName = Console.ReadLine();
        //    var cocktail = coCon.Get(cocktailName);
        //    if (cocktail != null)
        //    {
        //        Console.WriteLine("\r\nChoose to edit:");
        //        Console.WriteLine(" 1. Glass type");
        //        Console.WriteLine(" 2. Ingredients");
        //        Console.Write("\r\nYour choice: ");
        //        ConsoleKey key = Console.ReadKey().Key;
        //        if (key == ConsoleKey.D1)
        //        {
        //            ChangeCocktailGlassType(cocktail);
        //        }
        //        else if (key == ConsoleKey.D2)
        //        {
        //            ChangeCocktailIngredients(cocktail);
        //        }

        //    }
        //    coCon.Update(cocktail);
        //    UiPressAnyKeyToLeave();
        //}
        //static void ChangeCocktailGlassType(Cocktail cocktail)
        //{
        //    Console.Clear();
        //    Console.WriteLine("\r\nNew Glass type:");
        //    Console.WriteLine(" 1. Old Fashioned");
        //    Console.WriteLine(" 2. Collins");
        //    Console.WriteLine(" 3. Martini");
        //    Console.WriteLine(" 4. Highball");
        //    Console.WriteLine(" 5. Poco Grande");
        //    Console.WriteLine(" 6. Flute");
        //    GlassType type = GetGlassType(int.Parse(Console.ReadLine()));
        //    cocktail.GlassType = type;
        //}
        //static void ChangeCocktailIngredients(Cocktail cocktail)
        //{
        //    Console.Clear();
        //    Console.WriteLine(cocktail.Name + "'s ingredients:");
        //    for (int i = 0; i < cocktail.IngredientDescription.Count; i++)
        //    {
        //        Console.WriteLine((i + 1) + ". " + cocktail.IngredientDescription[i].Ingredient + " : " + cocktail.IngredientDescription[i].Description);
        //    }
        //    Console.Write("\r\nWrite ingredient number to update: ");
        //    try
        //    {
        //        int number = int.Parse(Console.ReadLine());
        //        if (number > 0 && number < cocktail.IngredientDescription.Count())
        //        {
        //            Console.Write("New ingredient amount: ");
        //            string newValue = Console.ReadLine();
        //            cocktail.IngredientDescription[(number - 1)].Description = newValue;
        //            Console.WriteLine("Changed ingredient amount");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}