using System.ComponentModel.DataAnnotations.Schema;

using RestaurantServiceSystem.API.Models.Enum;
{
    [Table("RestaurantTable")]
    public class RestaurantTable
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("RestaurantTableNumber")]
        public int RestaurantTableNumber { get; set; }

        [Column("InService")]
        public bool InService { get; set; }
    }
}
