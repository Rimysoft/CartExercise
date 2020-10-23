using CartExercise.Model;
using CartExercise.Services;
using System;
using System.Linq;

namespace CartExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CartService cartService = new CartService();

            cartService.InitCart();
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "book", Price = new PriceInfo(12.49), Type = ProductType.Book }, Quantity = 1 });
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "music CD", Price = new PriceInfo(14.99), Type = ProductType.Other }, Quantity = 1 });
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "chocolate bar", Price = new PriceInfo(0.85), Type = ProductType.Food }, Quantity = 1 });
            var descriptionStrings = cartService.GetCartSummary();
            if(descriptionStrings != null)
            {
                foreach (var d in descriptionStrings)
                {
                    Console.WriteLine(d);
                }
                
            }
            

        }
    }
}
