using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Console.WriteLine(recipe.Name);
            Console.WriteLine();
            Console.WriteLine("Ingredienser:");
            Console.WriteLine("{0}", recipe.Ingredients.ToString());
            Console.WriteLine();
            Console.WriteLine("Gör såhär:");
            Console.WriteLine("{0}", recipe.Instructions.ToString());
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe.Name);
                Console.WriteLine();
                Console.WriteLine("Ingredienser:");
                Console.WriteLine("{0}", recipe.Ingredients.ToString());
                Console.WriteLine();
                Console.WriteLine("Gör såhär:");
                Console.WriteLine("{0}", recipe.Instructions.ToString());
            }
        }
    }
}
