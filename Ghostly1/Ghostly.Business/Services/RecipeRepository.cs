using Ghostly.Business.Services.Interfaces;
using Ghostly.DAL.SQL;
using Ghostly.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Recipe = Ghostly.DAL.SQL.Recipe;

namespace Ghostly.Business
{
    public class RecipeRepository : IRecipeRepository
    {
        private GhostlyDBEntities db;

        public RecipeRepository()
        {
            db = new GhostlyDBEntities();
        }
        IEnumerable<RecipeModel> IRecipeRepository.GetAll()
        {
            IEnumerable<RecipeModel> listOfRecipe = (from objRecipe in db.Recipes
                                                     select new RecipeModel()
                                                     {
                                                         RecipeId = objRecipe.RecipeId,
                                                         ProductName = objRecipe.ProductName,
                                                         Variation = objRecipe.Variation,
                                                         CurrentPrice = objRecipe.CurrentPrice,
                                                         LastCost = objRecipe.LastCost,
                                                         Description = objRecipe.Description,
                                                         StandardRecipeId = objRecipe.StandardRecipeId,
                                                         OperatorId = objRecipe.OperatorId,
                                                         OperatorLocationId = objRecipe.OperatorLocationId,
                                                         date_creation = objRecipe.date_creation,
                                                         created_by = objRecipe.created_by,
                                                         modified_by = objRecipe.modified_by,
                                                         date_modified = objRecipe.date_modified
                                                     }).ToList();
            return listOfRecipe;
        }
        public void AddRecipe(RecipeModel recipeModel)
        {
            Recipe objRecipe = new Recipe()
            {
                RecipeId = recipeModel.RecipeId,
                ProductName = recipeModel.ProductName,
                Variation = recipeModel.Variation,
                CurrentPrice = recipeModel.CurrentPrice,
                LastCost = recipeModel.LastCost,
                Description = recipeModel.Description,
                StandardRecipeId = recipeModel.StandardRecipeId,
                OperatorId = recipeModel.OperatorId,
                OperatorLocationId = recipeModel.OperatorLocationId,
                date_creation = recipeModel.date_creation,
                created_by = recipeModel.created_by,
                modified_by = recipeModel.modified_by,
                date_modified = recipeModel.date_modified
            };
            db.Recipes.Add(objRecipe);
            db.SaveChanges();
        }
         public RecipeModel Detail(Guid RecipeId)
        {
         
            //return db.Recipe.Find(RecipeId);

            var Recipee = db.Recipes.Find(RecipeId);
            
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.RecipeId = Recipee.RecipeId;
            recipeModel.ProductName = Recipee.ProductName;
            recipeModel.Variation = Recipee.Variation;
            recipeModel.CurrentPrice = Recipee.CurrentPrice;
            recipeModel.LastCost = Recipee.LastCost;
            recipeModel.Description = Recipee.Description;
            recipeModel.StandardRecipeId = Recipee.StandardRecipeId;
            recipeModel.OperatorId = Recipee.OperatorId;
            recipeModel.OperatorLocationId = Recipee.OperatorLocationId;
            recipeModel.date_creation = Recipee.date_creation;
            recipeModel.created_by = Recipee.created_by;
            recipeModel.modified_by = Recipee.modified_by;
            recipeModel.date_modified = Recipee.date_modified;
            
            
            return recipeModel;
        }
        public void Delete(Guid? RecipeId)
        {
            var Recipee = db.Recipes.Find(RecipeId);
            db.Recipes.Remove(Recipee);
            db.SaveChanges();
        }

      
        public void Update(RecipeModel recipeModel)
        {
            var Recipee = db.Recipes.Find(recipeModel.RecipeId);
            Recipee.ProductName = recipeModel.ProductName;
            Recipee.Variation = recipeModel.Variation;
            Recipee.CurrentPrice = recipeModel.CurrentPrice;
            Recipee.LastCost = recipeModel.LastCost;
            Recipee.Description = recipeModel.Description;
            Recipee.StandardRecipeId = recipeModel.StandardRecipeId;
            Recipee.OperatorId = recipeModel.OperatorId;
            Recipee.OperatorLocationId = recipeModel.OperatorLocationId;
            Recipee.date_creation = recipeModel.date_creation;
            Recipee.created_by = recipeModel.created_by;
            Recipee.modified_by = recipeModel.modified_by;
            Recipee.date_modified = recipeModel.date_modified;
            db.Recipes.Add(Recipee);
            db.Entry(Recipee).State = EntityState.Modified;
            db.SaveChanges();
        }
    } 
}
