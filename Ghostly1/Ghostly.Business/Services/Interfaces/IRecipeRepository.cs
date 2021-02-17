using Ghostly.DAL.SQL;
using Ghostly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghostly.Business.Services.Interfaces
{
     public interface IRecipeRepository 
    {
        IEnumerable<RecipeModel> GetAll();
        void AddRecipe(RecipeModel recipeModel);
        RecipeModel Detail(Guid RecipeId);
        void Update(RecipeModel recipeModel);
        void Delete(Guid ? RecipeId);
        
    }
}