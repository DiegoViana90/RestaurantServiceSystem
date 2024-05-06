using System.ComponentModel.DataAnnotations.Schema;
using RestaurantServiceSystem.API.Models.Enum;

namespace RestaurantServiceSystem.Models
{
    [Table("Order")]
    public class Order
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("RestaurantTable")]
        public int RestaurantTableId { get; set; }

        [Column("OrderType")]
        public OrderType OrderType { get; set; }

        [Column("OpenOrder")]
        public bool OpenOrder { get; set; }

        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }

        [Column("ClosedDate")]
        public DateTime? ClosedDate { get; set; }
    }
}
