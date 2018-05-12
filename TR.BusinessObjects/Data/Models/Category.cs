using System.Collections.Generic;

namespace TR.BusinessObjects.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Recipe> Recipes{ get; set; }
    }
}