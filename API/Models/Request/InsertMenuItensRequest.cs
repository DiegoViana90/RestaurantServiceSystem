using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantServiceSystem.Models
{
    [Table("MenuItens")]
    public class InsertMenuItensRequest
    {
        [Column("Name")]
        public string Name { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("StockQuantity")]
        public int StockQuantity { get; set; }

        [Column("OrderType")]
        public OrderType OrderType { get; set; }
    }
}