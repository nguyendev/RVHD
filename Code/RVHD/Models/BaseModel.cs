using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models
{
    public class BaseModel
    {
        [Display(Name = "Trạng thái")]
        [StringLength(32)]
        public string Auth_status { get; set; }

        [Display(Name = "Ghi chú")]
        public string Notes { get; set; }

        [Display(Name = "Ngày tạo")]
        public Nullable<System.DateTime> Create_DT { get; set; }
        public int Record_Status { get; set; }
        [Display(Name = "Người duyệt")]
        public string Checker_ID { get; set; }
        [Display(Name = "Ngày xuất bản")]
        public Nullable<System.DateTime> Publish_DT { get; set; }
        public string AuthorId { get; set; }
       
        public Member Author { get; set; }
    }
}
