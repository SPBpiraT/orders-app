using System.ComponentModel.DataAnnotations;

namespace Orders.Web.Models.OrderViewModels
{
    public class OrderViewModel
    {
        public int OrderNum { get; set; }
        public string SenderCity { get; set; } = string.Empty;
        public string SenderAddress { get; set; } = string.Empty;
        public string RecipientCity { get; set; } = string.Empty;
        public string RecipientAddress { get; set; } = string.Empty;
        [Range(0.01, 100000.00, ErrorMessage = "Вес груза должен быть больше нуля")]
        public decimal CargoWeightKg { get; set; }
        public DateTimeOffset PickDate { get; set; }
    }
}
