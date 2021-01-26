using Cocktails.Controllers;
using Cocktails.Models.Entities;
using System.Collections.Generic;

namespace Cocktails
{
    public static class Data
    {
        private static CocktailController coCon = new CocktailController();
        private static IngredientController inCon = new IngredientController();

        public static void SetDefaultIngredients()
        {
            inCon.DeleteAll();

            inCon.Create(new Ingredient("Lime Juice", IngredientType.Liquid));
            inCon.Create(new Ingredient("Triple Sec", IngredientType.Liquid));
            inCon.Create(new Ingredient("Tequila", IngredientType.Liquid));
            inCon.Create(new Ingredient("Dark Rum", IngredientType.Liquid));
            inCon.Create(new Ingredient("Orange Curacao", IngredientType.Liquid));
            inCon.Create(new Ingredient("Almond Syrup", IngredientType.Liquid));
            inCon.Create(new Ingredient("Fresh Cream", IngredientType.Liquid));
            inCon.Create(new Ingredient("Kahlua", IngredientType.Liquid));
            inCon.Create(new Ingredient("Vodka", IngredientType.Liquid));
            inCon.Create(new Ingredient("Cachaca", IngredientType.Liquid));
            inCon.Create(new Ingredient("Orange Juice", IngredientType.Liquid));
            inCon.Create(new Ingredient("Tomato Juice", IngredientType.Liquid));
            inCon.Create(new Ingredient("Bourbon", IngredientType.Liquid));
            inCon.Create(new Ingredient("Water", IngredientType.Liquid));
            inCon.Create(new Ingredient("Italian Sweet Vermouth", IngredientType.Liquid));
            inCon.Create(new Ingredient("French Dry Vermouth", IngredientType.Liquid));
            inCon.Create(new Ingredient("Gin", IngredientType.Liquid));
            inCon.Create(new Ingredient("White Rum", IngredientType.Liquid));
            inCon.Create(new Ingredient("Pink Grapefruit Juice", IngredientType.Liquid));
            inCon.Create(new Ingredient("Grapefruit Juice", IngredientType.Liquid));
            inCon.Create(new Ingredient("Cranberry Juice", IngredientType.Liquid));
            inCon.Create(new Ingredient("Cointreau", IngredientType.Liquid));
            inCon.Create(new Ingredient("Soda", IngredientType.Liquid));
            inCon.Create(new Ingredient("Cherry Brandy", IngredientType.Liquid));
            inCon.Create(new Ingredient("Lemon Juice", IngredientType.Liquid));
            inCon.Create(new Ingredient("Sloe Gin", IngredientType.Liquid));
            inCon.Create(new Ingredient("Pineapple Juice", IngredientType.Liquid));
            inCon.Create(new Ingredient("Coconut Cream", IngredientType.Liquid));
            inCon.Create(new Ingredient("Cola", IngredientType.Liquid));
            inCon.Create(new Ingredient("Peach Puree", IngredientType.Liquid));
            inCon.Create(new Ingredient("Prosecco", IngredientType.Liquid));

            inCon.Create(new Ingredient("Salt Rim", IngredientType.Solid));
            inCon.Create(new Ingredient("Crushed Ice", IngredientType.Solid));
            inCon.Create(new Ingredient("Lime Segment", IngredientType.Solid));
            inCon.Create(new Ingredient("Lime Section", IngredientType.Solid));
            inCon.Create(new Ingredient("Maraschino Cherry", IngredientType.Solid));
            inCon.Create(new Ingredient("Caster Sugar", IngredientType.Solid));
            inCon.Create(new Ingredient("Ice Cube", IngredientType.Solid));
            inCon.Create(new Ingredient("Celery Stick", IngredientType.Solid));
            inCon.Create(new Ingredient("Worcestershire Sauce", IngredientType.Solid));
            inCon.Create(new Ingredient("Orange Slice", IngredientType.Solid));
            inCon.Create(new Ingredient("Brown Sugar", IngredientType.Solid));
            inCon.Create(new Ingredient("Cube Caster Sugar", IngredientType.Solid));
            inCon.Create(new Ingredient("Dash Angostura Bitters", IngredientType.Solid));
            inCon.Create(new Ingredient("Orange Peel", IngredientType.Solid));
            inCon.Create(new Ingredient("Orange Segment", IngredientType.Solid));
            inCon.Create(new Ingredient("Ice", IngredientType.Solid));
            inCon.Create(new Ingredient("Olive", IngredientType.Solid));
            inCon.Create(new Ingredient("Mint Leave", IngredientType.Solid));
            inCon.Create(new Ingredient("Splash Soda Water", IngredientType.Solid));
            inCon.Create(new Ingredient("Pineapple Segment", IngredientType.Solid));
        }
        public static void SetDefaultCocktails()
        {
            coCon.DeleteAll();

            coCon.Create(new Cocktail(
                "Margarita",
                GlassType.OldFashioned,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Lime Juice"), "60ml"),
                    new IngredientDescription(("Triple Sec"), "30ml"),
                    new IngredientDescription(("Tequila"), "60ml"),
                    new IngredientDescription(("Salt Rim"), "1x"),
                    new IngredientDescription(("Crushed Ice"), "1x"),
                    new IngredientDescription(("Lime Segment"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
               "Mai Tai",
               GlassType.OldFashioned,
               new List<IngredientDescription>()
               {
                    new IngredientDescription(("Dark Rum"), "50ml"),
                    new IngredientDescription(("Orange Curacao"), "15ml"),
                    new IngredientDescription(("Lime Juice"), "10ml"),
                    new IngredientDescription(("Almond Syrup"), "60ml"),
                    new IngredientDescription(("Lime Section"), "1x"),
                    new IngredientDescription(("Maraschino Cherry"), "1x"),
                    new IngredientDescription(("Lime Segment"), "1x"),
               })
            );
            coCon.Create(new Cocktail(
               "White Russian",
               GlassType.OldFashioned,
               new List<IngredientDescription>()
               {
                    new IngredientDescription(("Fresh Cream"), "30ml"),
                    new IngredientDescription(("Kahlua"), "30ml"),
                    new IngredientDescription(("Vodka"), "90ml"),
               })
            );
            coCon.Create(new Cocktail(
               "Caipirinha",
               GlassType.OldFashioned,
               new List<IngredientDescription>()
               {
                    new IngredientDescription(("Cachaca"), "50ml"),
                    new IngredientDescription(("Lime Segment"), "5x"),
                    new IngredientDescription(("Caster Sugar"), "2 tsp"),
               })
            );
            coCon.Create(new Cocktail(
               "Screwdriver",
               GlassType.Collins,
               new List<IngredientDescription>()
               {
                    new IngredientDescription(("Orange Juice"), "135ml"),
                    new IngredientDescription(("Vodka"), "45ml"),
               })
            );
            coCon.Create(new Cocktail(
               "Bloddy Mary",
               GlassType.Collins,
               new List<IngredientDescription>()
               {
                    new IngredientDescription(("Tomato Juice"), "135ml"),
                    new IngredientDescription(("Vodka"), "45ml"),
                    new IngredientDescription(("Ice Cube"), "Own preference"),
                    new IngredientDescription(("Celery Stick"), "1x"),
               })
            );
            coCon.Create(new Cocktail(
               "Whiskey Sour",
               GlassType.Collins,
               new List<IngredientDescription>()
               {
                    new IngredientDescription(("Bourbon"), "90ml"),
                    new IngredientDescription(("Lime Juice"), "40ml"),
                    new IngredientDescription(("Maraschino Cherry"), "1x"),
                    new IngredientDescription(("Orange Slice"), "0.5x"),
                    new IngredientDescription(("Brown Sugar"), "Own preference"),
               })
            );
            coCon.Create(new Cocktail(
              "Old Fashioned",
              GlassType.OldFashioned,
              new List<IngredientDescription>()
              {
                    new IngredientDescription(("Bourbon"), "50ml"),
                    new IngredientDescription(("Water"), "5ml"),
                    new IngredientDescription(("Cube Caster Sugar"), "1x"),
                    new IngredientDescription(("Dash Angostura Bitters"), "1x"),
                    new IngredientDescription(("Orange Peel"), "1x"),
                    new IngredientDescription(("Ice"), "1x"),
              })
            );
            coCon.Create(new Cocktail(
                "Manhatten",
                GlassType.Martini,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Italian Sweet Vermouth"), "25ml"),
                    new IngredientDescription(("Bourbon"), "45ml"),
                    new IngredientDescription(("Maraschino Cherry"), "1x"),
                    new IngredientDescription(("Dash Angostura Bitters"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Martini",
                GlassType.Martini,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("French Dry Vermouth"), "25ml"),
                    new IngredientDescription(("Gin"), "45ml"),
                    new IngredientDescription(("Olive"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Daiquiri",
                GlassType.Martini,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Lime Juice"), "25ml"),
                    new IngredientDescription(("White Rum"), "45ml"),
                    new IngredientDescription(("Brown Sugar"), "tsp"),
                })
            );
            coCon.Create(new Cocktail(
                "Cosmopolitan",
                GlassType.Martini,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Lime Juice"), "15ml"),
                    new IngredientDescription(("Pink Grapefruit Juice"), "15ml"),
                    new IngredientDescription(("Cranberry Juice"), "15ml"),
                    new IngredientDescription(("Cointreau"), "15ml"),
                    new IngredientDescription(("Vodka"), "15ml"),
                })
            );
            coCon.Create(new Cocktail(
                "Singapore Sling",
                GlassType.Highball,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Soda"), "250ml"),
                    new IngredientDescription(("Cherry Brandy"), "20ml"),
                    new IngredientDescription(("Lemon Juice"), "20x"),
                    new IngredientDescription(("Sloe Gin"), "20ml"),
                    new IngredientDescription(("Gin"), "45ml"),
                    new IngredientDescription(("Orange Segment"), "1x"),
                    new IngredientDescription(("Brown Sugar"), "tsp"),
                })
            );
            coCon.Create(new Cocktail(
                "Mojito",
                GlassType.Highball,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Lime Juice"), "20ml"),
                    new IngredientDescription(("White Rum"), "50ml"),
                    new IngredientDescription(("Mint Leave"), "10x"),
                    new IngredientDescription(("Caster Sugar"), "2tsp"),
                    new IngredientDescription(("Crushed Ice"), "Own Preference"),
                    new IngredientDescription(("Splash Soda Water"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Mint Julep",
                GlassType.Highball,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Water"), "300ml"),
                    new IngredientDescription(("Bourbon"), "60ml"),
                    new IngredientDescription(("Mint Leave"), "4x"),
                    new IngredientDescription(("Brown Sugar"), "tsp"),
                    new IngredientDescription(("Crushed Ice"), "4x"),
                })
            );
            coCon.Create(new Cocktail(
                "Tom Collins",
                GlassType.Highball,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Soda"), "220ml"),
                    new IngredientDescription(("Gin"), "50ml"),
                    new IngredientDescription(("Lemon Juice"), "25ml"),
                    new IngredientDescription(("Maraschino Cherry"), "1x"),
                    new IngredientDescription(("Orange Slice"), "1x"),
                    new IngredientDescription(("Brown Sugar"), "tsp"),
                    new IngredientDescription(("Ice Cube"), "3x"),
                })
            );
            coCon.Create(new Cocktail(
                "Pin Colada",
                GlassType.PocoGrande,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Pineapple Juice"), "70ml"),
                    new IngredientDescription(("White Rum"), "30ml"),
                    new IngredientDescription(("Coconut Cream"), "60ml"),
                    new IngredientDescription(("Pineapple Segment"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Sea Breeze",
                GlassType.Highball,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Grapefruit Juice"), "50ml"),
                    new IngredientDescription(("Cranberry Juice"), "120ml"),
                    new IngredientDescription(("Vodka"), "40ml"),
                    new IngredientDescription(("Ice"), "1x"),
                    new IngredientDescription(("Lime Segment"), "1x"),
                })
            );
            coCon.Create(new Cocktail(
                "Cuba Libre",
                GlassType.Highball,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Cola"), "80ml"),
                    new IngredientDescription(("Lime Juice"), "25ml"),
                    new IngredientDescription(("White Rum"), "50ml"),
                    new IngredientDescription(("Ice"), "3x"),
                })
            );
            coCon.Create(new Cocktail(
                "Bellini",
                GlassType.Flute,
                new List<IngredientDescription>()
                {
                    new IngredientDescription(("Peach Puree"), "50ml"),
                    new IngredientDescription(("Prosecco"), "100ml"),
                })
            );
        }
    }
}
