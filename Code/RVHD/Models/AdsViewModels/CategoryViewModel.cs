using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models.AdsViewModels
{
    public class CategoryViewModel
    {
        public int CategoriesSubItemId { get; set; }
        [Required]
        public int CategoriesItemId { get; set; }
        [Required]
        public int CategoriesId { get; set; }
    }
}
