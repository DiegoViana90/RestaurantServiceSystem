using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantServiceSystem.Models
{
    [Table("Order")]
    public class Order
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("TableNumber")]
        public int TableNumberId { get; set; }

        [Column("Food")]
        public string? FoodId { get; set; }

        [Column("Drink")]
        public string? DrinkId { get; set; }

        [Column("OpenOrder")]
        public bool OpenOrder { get; set; }

        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }

        [Column("ClosedDate")]
        public DateTime? ClosedDate { get; set; }
    }
}
