namespace ASP_NET_Task2_Products.Models;

public class Product
{
    private static int next_id = 1;
    public int id { get; set; } = 0;
    
    public string? image_path  = "/images/ product.png";
    public string name { get; set; }
    public string cost { get; set; }

    public Product()
    {
        
    }
    public Product(string name , string cost)
    {
        id = next_id++;
        this.name = name;
        this.cost = cost;
    }
}