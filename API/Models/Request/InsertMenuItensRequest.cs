using RestaurantServiceSystem.API.Models.Enum;

namespace RestaurantServiceSystem.API.Models.Request
{
    public class InsertMenuItensRequest
    {
        public string Name { get; set; }

        public int StockQuantity { get; set; }

        public OrderType OrderType { get; set; }
    }
}

