namespace Orders.Web.Models.OrderViewModels
{
    public class OrderViewModel
    {
        public int OrderNum { get; set; }
        public string SenderCity { get; set; } = string.Empty;
        public string SenderAddress { get; set; } = string.Empty;
        public string RecipientCity { get; set; } = string.Empty;
        public string RecipientAddress { get; set; } = string.Empty;
        public decimal CargoWeightKg { get; set; }
        public DateTimeOffset PickDate { get; set; }
    }
}
