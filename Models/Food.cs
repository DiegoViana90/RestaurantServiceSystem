using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantServiceSystem.Models
{
    [Table("Food")]
    public class Food
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
