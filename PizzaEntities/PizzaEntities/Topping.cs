using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PizzaEntities
{

    public class Topping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }

    }
}
