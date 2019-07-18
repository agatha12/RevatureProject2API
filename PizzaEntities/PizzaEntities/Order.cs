using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaEntities
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public bool delivery { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }
        public string address { get; set; }
    }
}
