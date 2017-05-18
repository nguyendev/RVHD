using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Models
{
    public class FavouriteAds : BaseModel
    {
        [Key]
        [Display(Name = "Mã chủ đề")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Who_Favourite_Id { get; set; }

        public string Fav_Poster_Id { get; set; }
        public string Fav_Ad_Id { get; set; }

        public Member Users { get; set; }
        public Ads Ads { get; set; }
    }
}
