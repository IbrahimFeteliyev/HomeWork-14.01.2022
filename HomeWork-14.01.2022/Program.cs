using HomeWork_14._01._2022.Class;
using HomeWork_14._01._2022.Methods;

SeoLink seoLink = new SeoLink();
Discount discount = new Discount();




Product product1 = new()
{
    Id = 1,
    Name = "Toyota Prius",
    Description = "Olkeye yeni gelib.pasi curuyu yoxdur.Kaliforniya masinidir. ",
    Price = 13.000M,
    //DiscountedPrice = discount.dis(13000),
    ProductionYear = 2008,
    SeoUrl = seoLink.Seo("Toyota Prius"),
    Created = DateTime.Now,
};

Product product2 = new()
{
    Id = 1,
    Name = "Jeep Wrangler",
    Description = "JEEP WRANGLER UNLIMITED WILLYS",
    Price = 65.000M,
    ProductionYear = 2021,
    SeoUrl = seoLink.Seo("Jeep Wrangler"),
    Created = DateTime.Now,
};

Product product3 = new()
{
    Id = 1,
    Name = "Kia Rio",
    Description = "Avtomobil olkeye yeni gelib. Butun xercleri gorulub.",
    Price = 17.600M,
    ProductionYear = 2014,
    SeoUrl = seoLink.Seo("Kia Rio"),
    Created = DateTime.Now,
};
Product product4 = new()
{
    Id = 1,
    Name = "BMW 528",
    Description = "Problemsiz masindi otur sur,hava yastigi acilmayib,suda batmiyib,nomresiz satirlir, zavod M.",
    Price = 24.000M,
    ProductionYear = 2014,
    SeoUrl = seoLink.Seo("BMW 528"),
    Created = DateTime.Now,
};
Product product5 = new()
{
    Id = 1,
    Name = "Ford Fusion",
    Description = "Masin Polnu Fuldu Masini ozum ucun getrmisdim 20 min manata gelib cxib.",
    Price = 18.800M,
    ProductionYear = 2013,
    SeoUrl = seoLink.Seo("Ford Fusion"),
    Created = DateTime.Now,
};



List<string> products = new();

//products.Add("Product name: " + product1.Name + " \n " + "Product Description: " + product1.Description + "\n" + "Product price :" + product1.Price+ "\n");


//Console.WriteLine(products);

Console.WriteLine("Product name: "  + product1.Name + "\n" + "Product Description: " + product1.Description + "Product Price: " + product1.Price + "Product ProductionYear :" + product1.ProductionYear + "\n" + "Product SeoUrl :" + product1.SeoUrl + "\n" + "Product Created :" + product1.Created);