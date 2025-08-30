

using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

#region addProducts
//Product veggieSpecial = new Product()
//{
//    Name = "Veggie Special Pizza",
//    Price = 9.99M
//};
//context.Products.Add(veggieSpecial);

//Product deluxeMeat = new Product()
//{
//    Name = "Deluxe Meat Pizza",
//    Price = 12.99M
//};
//context.Add(deluxeMeat);


//context.SaveChanges();


//Console.WriteLine("Products added to the database.");
//Console.ReadLine();
#endregion

#region ListProducts

//var productslst = context.Products
//                    //.Where(p => p.Price > 10.00M)
//                    .OrderBy(p => p.Name);

//foreach (Product p in productslst)
//{
//    Console.WriteLine($"Id:    {p.Id}");
//    Console.WriteLine($"Name:  {p.Name}");
//    Console.WriteLine($"Price: {p.Price}");
//    Console.WriteLine(new string('-', 20));
//}

#endregion


#region UpdateProductPrice
//var veggieSpecial = context.Products
//                       .Where(p => p.Name == "Veggie Special Pizza")
//                       .FirstOrDefault();

//if (veggieSpecial is Product)
//{
//    veggieSpecial.Price = 10.99M;
//}

//context.SaveChanges();

#endregion


#region Delete
var veggieSpecial = context.Products
                       .Where(p => p.Name == "Veggie Special Pizza")
                       .FirstOrDefault();

if (veggieSpecial is Product)
{
    context.Remove(veggieSpecial);
}

context.SaveChanges();

Console.WriteLine("Products Deleted");
Console.ReadLine();

#endregion