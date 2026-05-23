using Orders.Web.Entities;
using Orders.Web.Models.OrderViewModels;

namespace Orders.Web.Mapping
{
    internal static class OrderMappingExtensions
    {
        internal static Order MapToEntity(this OrderViewModel model)
        {
            return new Order
            {
                SenderCity = model.SenderCity,
                SenderAddress = model.SenderAddress,
                RecipientCity = model.RecipientCity,
                RecipientAddress = model.RecipientAddress,
                CargoWeightKg = model.CargoWeightKg,
                PickDate = model.PickDate.UtcDateTime
            };
        }

        internal static OrderViewModel MapToViewModel(this Order entity)
        {
            return new OrderViewModel
            {
                OrderNum = entity.OrderNum,
                SenderCity = entity.SenderCity,
                SenderAddress = entity.SenderAddress,
                RecipientCity = entity.RecipientCity,
                RecipientAddress = entity.RecipientAddress,
                CargoWeightKg = entity.CargoWeightKg,
                PickDate = entity.PickDate
            };
        }
    }
}
