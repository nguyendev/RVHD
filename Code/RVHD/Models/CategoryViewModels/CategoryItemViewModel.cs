using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models.CategoryViewModels
{
    public class CategoryItemViewModel
    {
        [Display(Name = "Mã chủ đề")]
        public int ID { get; set; }

        public int Categories_Id { get; set; }
        [Display(Name = "Tên chủ đề")]
        [Required(ErrorMessage = "Hãy nhập tên chủ đề")]

        [StringLength(256)]
        public string Ci_Name { get; set; }

        [Display(Name = "Mô tả chủ đề")]
        [Required(ErrorMessage = "Hãy nhập mô tả")]
        [StringLength(256)]
        public string Ci_Des { get; set; }
        [Display(Name = "Slug")]
        [Required(ErrorMessage = "Hãy nhập slug")]
        [StringLength(256)]
        public string Slug { get; set; }
        [Display(Name = "Icon")]
        public string Icon { get; set; }

        public string Color { get; set; }
        [Display(Name = "Thứ tự xuất hiện")]
        [Required(ErrorMessage = "Hãy nhập thứ tự")]

        public int OrderNo { get; set; }

        [Display(Name = "Trạng thái")]
        [StringLength(32)]
        public Categories Categories { get; set; }
        public ICollection<Ads> ListAds { get; set; }
        public ICollection<CategorySubItems> ListCategorySubItems { get; set; }

        public CategoryItemViewModel(){
            ListAds = new List<Ads>();
            foreach (var item in ListAds)
            {
                item.Image = item.Pic.Pic1;
            }
        } 
    }
}
