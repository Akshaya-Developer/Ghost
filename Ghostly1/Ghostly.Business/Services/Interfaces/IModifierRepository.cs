using Ghostly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghostly.Business.Services.Interfaces
{
    public interface IModifierRepository
    {
        IEnumerable<ModifierModel> GetAllModifiers();
        void AddModifier(ModifierModel modifierModel);
        ModifierModel Detail(Guid RecipeId);
        void Update(ModifierModel modifierModel);
        void Delete(Guid? RecipeId);
      
    }
}
