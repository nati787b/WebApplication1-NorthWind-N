// Written by Nathnael Tegegne
// 10/21/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using WebApplication1_NorthWind_N.Models;

namespace WebApplication1_NorthWind_N.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            File_Gateway aGateway = new File_Gateway();



            List<Category> aListOfCategories = aGateway.GetCategory("C:\\Users\\nati7\\source\\repos\\WebApplication1 NorthWind N\\Categories.csv");
            ViewBag.ListOfCategories = aListOfCategories;

            List<Employee> aListOfEmployees = aGateway.GetEmployee("C:\\Users\\nati7\\source\\repos\\WebApplication1 NorthWind N\\Employees.csv");
            ViewBag.ListOfEmployees = aListOfEmployees;

            List<OrderDetail> aListOfOrderDetails = aGateway.GetOrderDetail("C:\\Users\\nati7\\source\\repos\\WebApplication1 NorthWind N\\OrderDetails.csv");
            ViewBag.ListOfOrderDetails = aListOfOrderDetails;

            List<Product> aListOfProducts = aGateway.GetProduct("C:\\Users\\nati7\\source\\repos\\WebApplication1 NorthWind N\\Products.csv");
            ViewBag.ListOfProducts = aListOfProducts;

            List<Shipper> aListOfShippers = aGateway.GetShipper("C:\\Users\\nati7\\source\\repos\\WebApplication1 NorthWind N\\Shippers.csv");
            ViewBag.ListOfShippers = aListOfShippers;

            List<Supplier> aListOfSuppliers = aGateway.GetSupplier("C:\\Users\\nati7\\source\\repos\\WebApplication1 NorthWind N\\Suppliers.csv");
            ViewBag.ListOfSuppliers = aListOfSuppliers;

            return View();
        }
    }
}
