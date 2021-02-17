using Ghostly.DAL.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghostly.Business
{
    public class ConversionsDb
    {

        private GhostlyDBEntities db;

        public ConversionsDb()
        {
            db = new GhostlyDBEntities();
        }
        public IEnumerable<Conversion> GetAll() //Select List
        {
            return db.Conversions.ToList();
        }
        public Conversion GetById(int id) //Select Id for single Record
        {
            return db.Conversions.Find(id);
        }
        public void Insert(Conversion conversion)
        {
            db.Conversions.Add(conversion);
            Save();
        }
        public void Update(Conversion conversion)
        {
            db.Entry(conversion).State = System.Data.Entity.EntityState.Modified;
            Save();
        }
        public void Delete(int id)
        {
            Conversion conversion = db.Conversions.Find(id);
            db.Conversions.Remove(conversion);
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
