using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TR.BusinessObjects.Data.Models
{
    public class Recipe
    {
        [Key]
        public int RecipieId { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsFavorite { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category{ get; set; }

    }
}
