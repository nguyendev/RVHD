using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models
{
    public class Likes : BaseModel
    {
        [Key]
        [Display(Name = "Mã chủ đề")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int Product_Id { get; set; }
        public int Liker_id { get; set; }

        public Ads Ads { get; set; }
    }
}
