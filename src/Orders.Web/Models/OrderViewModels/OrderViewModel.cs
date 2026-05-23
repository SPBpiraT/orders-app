using System.ComponentModel.DataAnnotations;

namespace Orders.Web.Models.OrderViewModels
{
    public class OrderViewModel
    {
        [Display(Name = "Заказ №")]
        public int OrderNum { get; set; }

        [Display(Name = "Город отправителя")]
        [Required(ErrorMessage = "Введите город отправителя")]
        public string SenderCity { get; set; } = string.Empty;

        [Display(Name = "Адрес отправителя")]
        [Required(ErrorMessage = "Введите адрес отправителя")]
        public string SenderAddress { get; set; } = string.Empty;

        [Display(Name = "Город получателя")]
        [Required(ErrorMessage = "Введите город получателя")]
        public string RecipientCity { get; set; } = string.Empty;

        [Display(Name = "Адрес получателя")]
        [Required(ErrorMessage = "Введите адрес получателя")]
        public string RecipientAddress { get; set; } = string.Empty;

        [Display(Name = "Вес груза (кг)")]
        [Required(ErrorMessage = "Укажите вес груза")]
        [Range(0.01, 100000.00, ErrorMessage = "Вес груза должен быть больше нуля")]
        public decimal CargoWeightKg { get; set; }

        [Display(Name = "Дата забора груза")]
        [Required(ErrorMessage = "Выберите дату забора груза")]
        public DateTimeOffset PickDate { get; set; }
    }
}
