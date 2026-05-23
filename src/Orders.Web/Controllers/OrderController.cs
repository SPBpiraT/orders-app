using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Web.Data;
using Orders.Web.Mapping;
using Orders.Web.Models.OrderViewModels;

namespace Orders.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly AppDbContext _appDbContext;

        public OrderController(ILogger<OrderController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _appDbContext.Orders
                .AsNoTracking()
                .ToListAsync();

            var viewModels = orders.Select(o => o.MapToViewModel()).ToList();

            return View(new OrderListViewModel { Orders = viewModels });
        }

        public async Task<IActionResult> Get(int number)
        {
            var order = await _appDbContext.Orders
                .AsNoTracking()
                .FirstOrDefaultAsync(o => o.OrderNum == number);

            if (order == null)
            {
                return NotFound();
            }

            var viewModel = order.MapToViewModel();

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var order = model.MapToEntity();
            await _appDbContext.Orders.AddAsync(order);
            await _appDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


    }
}
