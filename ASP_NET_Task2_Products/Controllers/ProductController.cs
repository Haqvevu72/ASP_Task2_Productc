using ASP_NET_Task2_Products.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Task2_Products.Controllers;

public class ProductController: Controller
{
    private static List<Product> products; 
    private string image_path = "/images/ product.png";

    static ProductController()
    {
        products = new()
        {
            new Product("Product 1", "119"),
            new Product("Product 2", "129"),
            new Product("Product 3", "139"),
            new Product("Product 4", "149"),
            new Product("Product 5", "159"),
            new Product("Product 6", "169"),
            new Product("Product 7", "179"),
            new Product("Product 8", "189"),
            new Product("Product 9", "199"),
            new Product("Product 10", "209"),
            new Product("Product 11", "219"),
            new Product("Product 12", "229"),
            new Product("Product 13", "239"),
            new Product("Product 14", "249"),
            new Product("Product 15", "259"),
            new Product("Product 16", "269"),
            new Product("Product 17", "279"),
            new Product("Product 18", "289"),
            new Product("Product 19", "299"),
            new Product("Product 20", "309")
        };
    }

    public IActionResult GetAll()
    {
        return View(products);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Product p)
    {
        products.Add(new Product(p.name , p.cost));
        return RedirectToAction("GetAll");
    }

    [HttpGet]
    public IActionResult RemoveById()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult RemoveById(string id)
    {
        int Id = int.Parse(id);
        var product = products.FirstOrDefault(p => p.id == Id);
        products.Remove(product);
        return RedirectToAction("GetAll");
    }
    
    [HttpGet]
    public IActionResult RemoveByPrice()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RemoveByPrice(string price)
    {
        var product = products.FirstOrDefault(p => p.cost == price);
        products.Remove(product);
        return RedirectToAction("GetAll");
    }
}