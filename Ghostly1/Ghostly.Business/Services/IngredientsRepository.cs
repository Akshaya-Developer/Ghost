using Ghostly.DAL.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghostly.Business
{
    public class IngredientsDb
    {
        private GhostlyDBEntities db;

        public IngredientsDb()
        {
            db = new GhostlyDBEntities();
        }
        public IEnumerable<Ingredient> GetAll() //Select List
        {
            return db.Ingredients.ToList();
        }
        public Ingredient GetById(int id) //Select Id for single Record
        {
            return db.Ingredients.Find(id);
        }
        public void Insert(Ingredient ingredient)
        {
            db.Ingredients.Add(ingredient);
            Save();
        }
        public void Update(Ingredient ingredient)
        {
            db.Entry(ingredient).State = System.Data.Entity.EntityState.Modified;
            Save();
        }
        public void Delete(int id)
        {
            Ingredient ingredient = db.Ingredients.Find(id);
            db.Ingredients.Remove(ingredient);
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
