using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
	public class CustomerOrdersController : Controller
	{
		public IActionResult Index()
		{
			var customer = new Customer
			{
				Id = 5,
				FirstName = "Umut",
				LastName = "Aydın",
				Email = "umutaydin@gmail.com"
			};

			var orders = new List<Order>
		   {
			   new Order {Id= 1, ProductName = "Pen", Price = 20, Quantity = 5},
			   new Order {Id= 2, ProductName = "Book", Price = 120, Quantity = 2},
			   new Order {Id= 3, ProductName = "Notebook", Price = 15, Quantity = 2},
			   new Order {Id= 4, ProductName = "Ruler", Price = 35, Quantity = 1},
			   new Order {Id= 4, ProductName = "Backpack", Price = 250, Quantity = 1}
			};

			var customerOrderViewModel = new CustomerOrderViewModel
			{
				Customer = customer,
				Orders = orders
			};

			return View(customerOrderViewModel);
		}
	}
}