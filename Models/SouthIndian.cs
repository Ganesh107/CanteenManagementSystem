using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CanteenManagement.Models
{
    public class SouthIndian
    {
        [Key]
        [DisplayName("Id")]
        public int id { get; set; }

        [Required(ErrorMessage ="Please enter the name")]
        [StringLength(50)]
        [DisplayName("Item Name")]
        [Column(TypeName = "nvarchar")]
        public string itemname { get; set; }

        [Required(ErrorMessage ="Please enter the price")]
        [DisplayName("Price")]
        public float price { get; set; }
    }
}