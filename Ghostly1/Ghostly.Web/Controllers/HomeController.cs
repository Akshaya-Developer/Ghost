using Ghostly.Business;
using Ghostly.Business.Services.Interfaces;
using Ghostly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Ghostly.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeRepository recipeRepository;
        public HomeController(IRecipeRepository _recipeRepository) //Constructor Dependency Injection
        {
            recipeRepository = _recipeRepository;
        }
        // GET: Home
        public ActionResult GetAllRecipe()
        {
            IEnumerable<RecipeModel> listOfRecipe = recipeRepository.GetAll();
            return View(listOfRecipe);
        }
        [HttpGet]
        public ActionResult AddRecipe( )
        { 
            return View();
        }
        public ActionResult AddRecipe(RecipeModel objRecipe)
        {
            objRecipe.RecipeId = Guid.NewGuid();

            recipeRepository.AddRecipe(objRecipe);
            return RedirectToAction("GetAllRecipe");

        }
        public ActionResult Update(Guid id)
        {

            return View(recipeRepository.Detail(id));
        }
        [HttpPost]
        public ActionResult Update(RecipeModel recipeModel)
        {
            recipeRepository.Update(recipeModel);
            return RedirectToAction("GetAllRecipe");
        }
        
       

        //[HttpPost]
        public ActionResult Detail(Guid id)
        {
            
            //recipeRepository.Detail(id);
            return View(recipeRepository.Detail(id));
        }
       
        public ActionResult Delete (Guid? RecipeId)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            recipeRepository.Delete(id);
            return RedirectToAction("GetAllRecipe");
        }
    }
}