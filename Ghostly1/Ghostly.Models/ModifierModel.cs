using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghostly.Models
{
    public class ModifierModel
    {
        public System.Guid ModifierId { get; set; }
        public Nullable<System.Guid> RecipeId { get; set; }
        public Nullable<System.Guid> IngredientId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string UnitType { get; set; }
        public string OrderType { get; set; }
        public Nullable<decimal> CurrentPrice { get; set; }
        public Nullable<decimal> LastCost { get; set; }
        public System.DateTime date_creation { get; set; }
        public Nullable<System.Guid> created_by { get; set; }
        public Nullable<System.Guid> modified_by { get; set; }
        public Nullable<System.DateTime> date_modified { get; set; }

        [MetadataType(typeof(ModifierModel))]
        public partial class Modifier
        {

        }

    }
}
