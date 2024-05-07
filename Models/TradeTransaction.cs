namespace TestApi.Models
{
    public class TradeTransaction
    {
        public int Id { get; set; }
        public int TradeId { get; set; }
        public string ContractDetails { get; set; }
        public string Product { get; set; }
        public string ShippingDetails { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
    }

}
