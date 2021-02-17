using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghostly.Models
{
    // [Table("Recipes")]
    public class RecipeModel
    {
        public System.Guid RecipeId { get; set; }
        public string ProductName { get; set; }
        public string Variation { get; set; }
        public Nullable<decimal> CurrentPrice { get; set; }
        public Nullable<decimal> LastCost { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> StandardRecipeId { get; set; }
        public Nullable<System.Guid> OperatorId { get; set; }
        public Nullable<System.Guid> OperatorLocationId { get; set; }
        public System.DateTime date_creation { get; set; }
        public Nullable<System.Guid> created_by { get; set; }
        public Nullable<System.Guid> modified_by { get; set; }
        public Nullable<System.DateTime> date_modified { get; set; }

        [MetadataType(typeof(RecipeModel))]
        public partial class Recipe
        {

        }
    }
}
