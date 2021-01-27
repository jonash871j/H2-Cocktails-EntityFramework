using Cocktails.Controllers;
using Cocktails.Models.Entities;
using System.Collections.Generic;

namespace Cocktails
{
    public static class Data
    {
        private static CocktailController coCon = new CocktailController();
        private static FoodController inCon = new FoodController();

        public static void SetDefaultIngredients()
        {
            inCon.DeleteAll();

            inCon.Create(new Food("Lime Juice", FoodType.Liquid));
            inCon.Create(new Food("Triple Sec", FoodType.Liquid));
            inCon.Create(new Food("Tequila", FoodType.Liquid));
            inCon.Create(new Food("Dark Rum", FoodType.Liquid));
            inCon.Create(new Food("Orange Curacao", FoodType.Liquid));
            inCon.Create(new Food("Almond Syrup", FoodType.Liquid));
            inCon.Create(new Food("Fresh Cream", FoodType.Liquid));
            inCon.Create(new Food("Kahlua", FoodType.Liquid));
            inCon.Create(new Food("Vodka", FoodType.Liquid));
            inCon.Create(new Food("Cachaca", FoodType.Liquid));
            inCon.Create(new Food("Orange Juice", FoodType.Liquid));
            inCon.Create(new Food("Tomato Juice", FoodType.Liquid));
            inCon.Create(new Food("Bourbon", FoodType.Liquid));
            inCon.Create(new Food("Water", FoodType.Liquid));
            inCon.Create(new Food("Italian Sweet Vermouth", FoodType.Liquid));
            inCon.Create(new Food("French Dry Vermouth", FoodType.Liquid));
            inCon.Create(new Food("Gin", FoodType.Liquid));
            inCon.Create(new Food("White Rum", FoodType.Liquid));
            inCon.Create(new Food("Pink Grapefruit Juice", FoodType.Liquid));
            inCon.Create(new Food("Grapefruit Juice", FoodType.Liquid));
            inCon.Create(new Food("Cranberry Juice", FoodType.Liquid));
            inCon.Create(new Food("Cointreau", FoodType.Liquid));
            inCon.Create(new Food("Soda", FoodType.Liquid));
            inCon.Create(new Food("Cherry Brandy", FoodType.Liquid));
            inCon.Create(new Food("Lemon Juice", FoodType.Liquid));
            inCon.Create(new Food("Sloe Gin", FoodType.Liquid));
            inCon.Create(new Food("Pineapple Juice", FoodType.Liquid));
            inCon.Create(new Food("Coconut Cream", FoodType.Liquid));
            inCon.Create(new Food("Cola", FoodType.Liquid));
            inCon.Create(new Food("Peach Puree", FoodType.Liquid));
            inCon.Create(new Food("Prosecco", FoodType.Liquid));

            inCon.Create(new Food("Salt Rim", FoodType.Solid));
            inCon.Create(new Food("Crushed Ice", FoodType.Solid));
            inCon.Create(new Food("Lime Segment", FoodType.Solid));
            inCon.Create(new Food("Lime Section", FoodType.Solid));
            inCon.Create(new Food("Maraschino Cherry", FoodType.Solid));
            inCon.Create(new Food("Caster Sugar", FoodType.Solid));
            inCon.Create(new Food("Ice Cube", FoodType.Solid));
            inCon.Create(new Food("Celery Stick", FoodType.Solid));
            inCon.Create(new Food("Worcestershire Sauce", FoodType.Solid));
            inCon.Create(new Food("Orange Slice", FoodType.Solid));
            inCon.Create(new Food("Brown Sugar", FoodType.Solid));
            inCon.Create(new Food("Cube Caster Sugar", FoodType.Solid));
            inCon.Create(new Food("Dash Angostura Bitters", FoodType.Solid));
            inCon.Create(new Food("Orange Peel", FoodType.Solid));
            inCon.Create(new Food("Orange Segment", FoodType.Solid));
            inCon.Create(new Food("Ice", FoodType.Solid));
            inCon.Create(new Food("Olive", FoodType.Solid));
            inCon.Create(new Food("Mint Leave", FoodType.Solid));
            inCon.Create(new Food("Splash Soda Water", FoodType.Solid));
            inCon.Create(new Food("Pineapple Segment", FoodType.Solid));
        }
        public static void SetDefaultCocktails()
        {
            coCon.DeleteAll();

            coCon.Create(new Cocktail(
                "Margarita",
                GlassType.OldFashioned,
                new List<Ingredient>()
                {
                    new Ingredient(("Lime Juice"), "60ml"),
                    new Ingredient(("Triple Sec"), "30ml"),
                    new Ingredient(("Tequila"), "60ml"),
                    new Ingredient(("Salt Rim"), "1x"),
                    new Ingredient(("Crushed Ice"), "1x"),
                    new Ingredient(("Lime Segment"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
               "Mai Tai",
               GlassType.OldFashioned,
               new List<Ingredient>()
               {
                    new Ingredient(("Dark Rum"), "50ml"),
                    new Ingredient(("Orange Curacao"), "15ml"),
                    new Ingredient(("Lime Juice"), "10ml"),
                    new Ingredient(("Almond Syrup"), "60ml"),
                    new Ingredient(("Lime Section"), "1x"),
                    new Ingredient(("Maraschino Cherry"), "1x"),
                    new Ingredient(("Lime Segment"), "1x"),
               })
            );
            coCon.Create(new Cocktail(
               "White Russian",
               GlassType.OldFashioned,
               new List<Ingredient>()
               {
                    new Ingredient(("Fresh Cream"), "30ml"),
                    new Ingredient(("Kahlua"), "30ml"),
                    new Ingredient(("Vodka"), "90ml"),
               })
            );
            coCon.Create(new Cocktail(
               "Caipirinha",
               GlassType.OldFashioned,
               new List<Ingredient>()
               {
                    new Ingredient(("Cachaca"), "50ml"),
                    new Ingredient(("Lime Segment"), "5x"),
                    new Ingredient(("Caster Sugar"), "2 tsp"),
               })
            );
            coCon.Create(new Cocktail(
               "Screwdriver",
               GlassType.Collins,
               new List<Ingredient>()
               {
                    new Ingredient(("Orange Juice"), "135ml"),
                    new Ingredient(("Vodka"), "45ml"),
               })
            );
            coCon.Create(new Cocktail(
               "Bloddy Mary",
               GlassType.Collins,
               new List<Ingredient>()
               {
                    new Ingredient(("Tomato Juice"), "135ml"),
                    new Ingredient(("Vodka"), "45ml"),
                    new Ingredient(("Ice Cube"), "Own preference"),
                    new Ingredient(("Celery Stick"), "1x"),
               })
            );
            coCon.Create(new Cocktail(
               "Whiskey Sour",
               GlassType.Collins,
               new List<Ingredient>()
               {
                    new Ingredient(("Bourbon"), "90ml"),
                    new Ingredient(("Lime Juice"), "40ml"),
                    new Ingredient(("Maraschino Cherry"), "1x"),
                    new Ingredient(("Orange Slice"), "0.5x"),
                    new Ingredient(("Brown Sugar"), "Own preference"),
               })
            );
            coCon.Create(new Cocktail(
              "Old Fashioned",
              GlassType.OldFashioned,
              new List<Ingredient>()
              {
                    new Ingredient(("Bourbon"), "50ml"),
                    new Ingredient(("Water"), "5ml"),
                    new Ingredient(("Cube Caster Sugar"), "1x"),
                    new Ingredient(("Dash Angostura Bitters"), "1x"),
                    new Ingredient(("Orange Peel"), "1x"),
                    new Ingredient(("Ice"), "1x"),
              })
            );
            coCon.Create(new Cocktail(
                "Manhatten",
                GlassType.Martini,
                new List<Ingredient>()
                {
                    new Ingredient(("Italian Sweet Vermouth"), "25ml"),
                    new Ingredient(("Bourbon"), "45ml"),
                    new Ingredient(("Maraschino Cherry"), "1x"),
                    new Ingredient(("Dash Angostura Bitters"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Martini",
                GlassType.Martini,
                new List<Ingredient>()
                {
                    new Ingredient(("French Dry Vermouth"), "25ml"),
                    new Ingredient(("Gin"), "45ml"),
                    new Ingredient(("Olive"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Daiquiri",
                GlassType.Martini,
                new List<Ingredient>()
                {
                    new Ingredient(("Lime Juice"), "25ml"),
                    new Ingredient(("White Rum"), "45ml"),
                    new Ingredient(("Brown Sugar"), "tsp"),
                })
            );
            coCon.Create(new Cocktail(
                "Cosmopolitan",
                GlassType.Martini,
                new List<Ingredient>()
                {
                    new Ingredient(("Lime Juice"), "15ml"),
                    new Ingredient(("Pink Grapefruit Juice"), "15ml"),
                    new Ingredient(("Cranberry Juice"), "15ml"),
                    new Ingredient(("Cointreau"), "15ml"),
                    new Ingredient(("Vodka"), "15ml"),
                })
            );
            coCon.Create(new Cocktail(
                "Singapore Sling",
                GlassType.Highball,
                new List<Ingredient>()
                {
                    new Ingredient(("Soda"), "250ml"),
                    new Ingredient(("Cherry Brandy"), "20ml"),
                    new Ingredient(("Lemon Juice"), "20x"),
                    new Ingredient(("Sloe Gin"), "20ml"),
                    new Ingredient(("Gin"), "45ml"),
                    new Ingredient(("Orange Segment"), "1x"),
                    new Ingredient(("Brown Sugar"), "tsp"),
                })
            );
            coCon.Create(new Cocktail(
                "Mojito",
                GlassType.Highball,
                new List<Ingredient>()
                {
                    new Ingredient(("Lime Juice"), "20ml"),
                    new Ingredient(("White Rum"), "50ml"),
                    new Ingredient(("Mint Leave"), "10x"),
                    new Ingredient(("Caster Sugar"), "2tsp"),
                    new Ingredient(("Crushed Ice"), "Own Preference"),
                    new Ingredient(("Splash Soda Water"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Mint Julep",
                GlassType.Highball,
                new List<Ingredient>()
                {
                    new Ingredient(("Water"), "300ml"),
                    new Ingredient(("Bourbon"), "60ml"),
                    new Ingredient(("Mint Leave"), "4x"),
                    new Ingredient(("Brown Sugar"), "tsp"),
                    new Ingredient(("Crushed Ice"), "4x"),
                })
            );
            coCon.Create(new Cocktail(
                "Tom Collins",
                GlassType.Highball,
                new List<Ingredient>()
                {
                    new Ingredient(("Soda"), "220ml"),
                    new Ingredient(("Gin"), "50ml"),
                    new Ingredient(("Lemon Juice"), "25ml"),
                    new Ingredient(("Maraschino Cherry"), "1x"),
                    new Ingredient(("Orange Slice"), "1x"),
                    new Ingredient(("Brown Sugar"), "tsp"),
                    new Ingredient(("Ice Cube"), "3x"),
                })
            );
            coCon.Create(new Cocktail(
                "Pin Colada",
                GlassType.PocoGrande,
                new List<Ingredient>()
                {
                    new Ingredient(("Pineapple Juice"), "70ml"),
                    new Ingredient(("White Rum"), "30ml"),
                    new Ingredient(("Coconut Cream"), "60ml"),
                    new Ingredient(("Pineapple Segment"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Sea Breeze",
                GlassType.Highball,
                new List<Ingredient>()
                {
                    new Ingredient(("Grapefruit Juice"), "50ml"),
                    new Ingredient(("Cranberry Juice"), "120ml"),
                    new Ingredient(("Vodka"), "40ml"),
                    new Ingredient(("Ice"), "1x"),
                    new Ingredient(("Lime Segment"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Cuba Libre",
                GlassType.Highball,
                new List<Ingredient>()
                {
                    new Ingredient(("Cola"), "80ml"),
                    new Ingredient(("Lime Juice"), "25ml"),
                    new Ingredient(("White Rum"), "50ml"),
                    new Ingredient(("Ice"), "3x"),
                })
            );
            coCon.Create(new Cocktail(
                "Bellini",
                GlassType.Flute,
                new List<Ingredient>()
                {
                    new Ingredient(("Peach Puree"), "50ml"),
                    new Ingredient(("Prosecco"), "100ml"),
                })
            );
        }
    }
}
