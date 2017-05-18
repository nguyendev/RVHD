using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models.AdsViewModels
{
    public class AdsViewModel
    {
        [Key]
        [Display(Name = "Mã chủ đề")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int CategoriesSubItemId { get; set; }

        public int CategoriesItemId { get; set; }

        public int CategoriesId { get; set; }
        public string Slug { get; set; }
        public string BrandId { get; set; }

        public string AdTitle { get; set; }

        public string AdDes { get; set; }
        public string AdPrice { get; set; }
        public string AdOldPrice { get; set; }
        public string AdOwnerName { get; set; }
        public string AdOwnerEmail { get; set; }
        public string AdOwnerPhone { get; set; }
        public string AdOwnerAdress { get; set; }

        public string City { get; set; }
        public string Ad_Latitude { get; set; }
        public string Ad_Longitude { get; set; }
        public string Product_specs { get; set; }

        public string Image { get; set; }

        public CategorySubItems CategorySubItems { get; set; }
        public AdsPics Pics { get; set; }
    }
}
