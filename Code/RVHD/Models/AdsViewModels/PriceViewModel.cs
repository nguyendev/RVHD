using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models.AdsViewModels
{
    public class PriceViewModel
    {
        [Display(Name = "Mã chủ đề")]
        public int ID { get; set; }
        [Required]
        public int CategoriesSubItemId { get; set; }
        [Required]
        public int CategoriesItemId { get; set; }
        [Required]
        public int CategoriesId { get; set; }
        public string Slug { get; set; }
        public string BrandId { get; set; }
        [Required]
        public string AdTitle { get; set; }
        [Required]
        public string AdDes { get; set; }
        [Required]
        public string AdPrice { get; set; }

        public string AdOldPrice { get; set; }
        public string AdOwnerName { get; set; }
        public string AdOwnerEmail { get; set; }
        public string AdOwnerPhone { get; set; }
    }
}
