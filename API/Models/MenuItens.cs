using System.ComponentModel.DataAnnotations.Schema;
using RestaurantServiceSystem.API.Models.Enum;

namespace RestaurantServiceSystem.Models
{
    [Table("MenuItens")]
    public class MenuItens
    {
        [Column("Id")]
        public int Id { get; set; }

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