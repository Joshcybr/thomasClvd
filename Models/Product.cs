namespace thomasClvd.Models;
public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; } // Add Category property
    public string Availability { get; set; } // Add Availability property
}
