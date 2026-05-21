using Microsoft.AspNetCore.Mvc;

namespace Orders.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(); //Get all
        }
        public async Task<IActionResult> Get() //Guid id
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return View();
        }


    }
}
