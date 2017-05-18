using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models
{
    public class CategorySubItems :BaseModel
    {
        [Key]
        [Display(Name = "Mã chủ đề")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int Cs_Id { get; set; }
        [Display(Name = "Tên chủ đề")]
        [Required(ErrorMessage = "Hãy nhập tên chủ đề")]

        [StringLength(256)]
        public string Ci_Name { get; set; }

        [Display(Name = "Mô tả chủ đề")]
        [Required(ErrorMessage = "Hãy nhập mô tả")]
        [StringLength(256)]
        public string Ci_Des { get; set; }
        public string Slug { get; set; }
        [Display(Name = "Thứ tự xuất hiện")]
        [Required(ErrorMessage = "Hãy nhập thứ tự")]
        public int OrderNo { get; set; }
        [Display(Name = "Icon")]
        public string Icon { get; set; }

       
        public CategoryItems CategoryItems { get; set; }

        public ICollection<Ads> ListAds { get; set; }

        public CategorySubItems()
        {
            ListAds = new List<Ads>();
        }
    }
}
