using AutoMapper;
using Ghostly.Business.Services.Interfaces;
using Ghostly.DAL.SQL;
using Ghostly.Models;
using IKVM.Attributes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modifier = Ghostly.DAL.SQL.Modifier;

namespace Ghostly.Business
{
    public class ModifierRepository : IModifierRepository
    {
        private GhostlyDBEntities db;
        public ModifierRepository()
        {
            db = new GhostlyDBEntities();
        }
        IEnumerable<ModifierModel> IModifierRepository.GetAllModifiers()
        {
            


            Ghostly.Models.ModifierModel modiferModel = Mapper.Map<Ghostly.DAL.SQL.Modifier, Ghostly.Models.ModifierModel>(objModifier);

            IEnumerable<ModifierModel> listOfModifiers = (from objModifier in db.Modifiers
                                                          select new ModifierModel()
                                                          {
        //Mapper.Map<Modifier, ModifierModel>(objModifier);
            //ModifierId = objModifier.ModifierId,
            //RecipeId = objModifier.RecipeId,
            //IngredientId = objModifier.IngredientId,
            //Quantity = objModifier.Quantity,
            //UnitType = objModifier.UnitType,
            ////OrderType = objModifier.OrderType,
            //CurrentPrice = objModifier.CurrentPrice,
            //LastCost = objModifier.LastCost,
            //date_creation = objModifier.date_creation,
            //created_by = objModifier.created_by,
            //modified_by = objModifier.modified_by,
            //date_modified = objModifier.date_modified
        }).ToList();
            return listOfModifiers;
        }

        public void AddModifier(ModifierModel modifierModel)
        {
            Modifier objModifier = new Modifier()
            {
                ModifierId = modifierModel.ModifierId,
                RecipeId = modifierModel.RecipeId,
                IngredientId = modifierModel.IngredientId,
                Quantity = modifierModel.Quantity,
                UnitType = modifierModel.UnitType,
                //OrderType = modifierModel.OrderType,
                CurrentPrice = modifierModel.CurrentPrice,
                LastCost = modifierModel.LastCost,
                date_creation = modifierModel.date_creation,
                created_by = modifierModel.created_by,
                modified_by = modifierModel.modified_by,
                date_modified = modifierModel.date_modified
            };
            db.Modifiers.Add(objModifier);
            db.SaveChanges();
        }
        public void Update(ModifierModel modifierModel)
        {
            var Modify = db.Modifiers.Find(modifierModel.ModifierId);
            Modify.ModifierId = modifierModel.ModifierId;
            Modify.RecipeId = modifierModel.RecipeId;
            Modify.IngredientId = modifierModel.IngredientId;
            Modify.Quantity = modifierModel.Quantity;
            Modify.UnitType = modifierModel.UnitType;
            //Modify.OrderType = modifierModel.OrderType;
            Modify.CurrentPrice = modifierModel.CurrentPrice;
            Modify.LastCost = modifierModel.LastCost;
            Modify.date_creation = modifierModel.date_creation;
            Modify.created_by = modifierModel.created_by;
            Modify.modified_by = modifierModel.modified_by;
            Modify.date_modified = modifierModel.date_modified;

            db.Modifiers.Add(Modify);
            db.Entry(Modify).State = EntityState.Modified;
            db.SaveChanges();
        }
        public ModifierModel Detail(Guid ModifierId)
        {
            var Modify = db.Modifiers.Find(ModifierId);

            ModifierModel modifierModel = new ModifierModel();

            modifierModel.ModifierId = Modify.ModifierId;
            modifierModel.RecipeId = Modify.RecipeId;
            modifierModel.IngredientId = Modify.IngredientId;
            modifierModel.Quantity = Modify.Quantity;
            modifierModel.UnitType = Modify.UnitType;
            //modifierModel.OrderType = Modify.OrderType;
            modifierModel.CurrentPrice = Modify.CurrentPrice;
            modifierModel.LastCost = Modify.LastCost;
            modifierModel.date_creation = Modify.date_creation;
            modifierModel.created_by = Modify.created_by;
            modifierModel.modified_by = Modify.modified_by;
            modifierModel.date_modified = Modify.date_modified;


            return modifierModel;
        }
        public void Delete(Guid? ModifierId)
        {
            var Modify = db.Modifiers.Find(ModifierId);
            db.Modifiers.Remove(Modify);
            db.SaveChanges();
        }
    }
}

