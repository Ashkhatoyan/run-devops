using Shopping.client.Models;

namespace Shopping.client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "IPhone X",
                Description = "Dasinged by Apple California 2018",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Smartphone",
            },
            new Product()
            {
                Name = "IPhone 11",
                Description = "Dasinged by Apple California 2019",
                ImageFile = "product-2.png",
                Price = 1000.00M,
                Category = "Smartphone",
            },
            new Product()
            {
                Name = "IPhone 11 Pro Max",
                Description = "Dasinged by Apple California 2019",
                ImageFile = "product-3.png",
                Price = 1200.00M,
                Category = "Smartphone",
            },
            new Product()
            {
                Name = "IPhone 12 Mini",
                Description = "Dasinged by Apple California 2020",
                ImageFile = "product-4.png",
                Price = 950.00M,
                Category = "Smartphone",
            },
            new Product()
            {
                Name = "IPhone 12 Pro",
                Description = "Dasinged by Apple California 2020",
                ImageFile = "product-5.png",
                Price = 1400.00M,
                Category = "Smartphone",
            },
        };
    }
}
