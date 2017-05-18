using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models.CategoryViewModels
{
    public class CategoryViewModel
    {
        [Display(Name = "Mã chủ đề")]
        public int ID { get; set; }
        [Display(Name = "Tên chủ đề")]
        [Required(ErrorMessage = "Hãy nhập tên chủ đề")]

        [StringLength(256)]
        public string CategoryName { get; set; }

        [Display(Name = "Mô tả chủ đề")]
        [Required(ErrorMessage = "Hãy nhập mô tả")]
        [StringLength(256)]
        public string CategoryDes { get; set; }
        [Display(Name = "Slug")]
        [Required(ErrorMessage = "Hãy nhập slug")]
        [StringLength(256)]
        public string Slug { get; set; }
        [Display(Name = "Icon")]
        public string Icon { get; set; }
        [Display(Name = "Color")]
        public string Color { get; set; }


        [Display(Name = "Thứ tự xuất hiện")]
        [Required(ErrorMessage = "Hãy nhập thứ tự")]
        public int OrderNo { get; set; }

        public ICollection<CategoryItems> ListCategoryItems { get; set; }
    }
}
