using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CanteenManagement.Models
{
    public class NorthIndian
    {
        [Key]
        [DisplayName("S.NO")]
        public int id { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        [StringLength(50)]
        [DisplayName("Item Name")]
        [Column(TypeName = "nvarchar")]
        public string itemname { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        [DisplayName("Price")]
        public float price { get; set; }
    }
}