
namespace WebApplication1.ApplicationServices
{
    /// <summary>
    /// Questo servizio utilizza degli altri servizi che vengono iniettati per mezzo di IoC container
    /// </summary>
    public class CompositeService : ICompositeService
    {
        IOrderService _orderService;

        public CompositeService(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public string GetCompositeData()
        {
            return _orderService.GetOrderId().ToString();
        }
    }
}
