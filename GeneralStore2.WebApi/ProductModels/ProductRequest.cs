namespace GeneralStore2.WebApi.ProductModels;

public class ProductRequest
{
    public string Name { get; set; }
    public int QuantityInStock { get; set; }
    public double Price { get; set; }
}