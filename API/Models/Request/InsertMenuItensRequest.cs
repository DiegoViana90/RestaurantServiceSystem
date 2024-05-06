using RestaurantServiceSystem.Models.Enum;

namespace RestaurantServiceSystem.Models.Request
{
    public class InsertMenuItensRequest
    {
        public string Name { get; set; }

        public int StockQuantity { get; set; }

        public OrderType OrderType { get; set; }
    }
}
