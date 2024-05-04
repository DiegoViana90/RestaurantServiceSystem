using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantServiceSystem.Models
{
    [Table("Drink")]
    public class Drink
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
