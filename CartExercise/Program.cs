using CartExercise.Model;
using CartExercise.Services;
using System;
using System.Linq;

namespace CartExercise
{
    class Program
    {

        private static void Case1()
        {
            CartService cartService = new CartService();

            cartService.InitCart();
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "book", Price = new PriceInfo(12.49), Type = ProductType.Book }, Quantity = 1 });
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "music CD", Price = new PriceInfo(14.99), Type = ProductType.Other }, Quantity = 1 });
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "chocolate bar", Price = new PriceInfo(0.85), Type = ProductType.Food }, Quantity = 1 });

            var cartProductsStrings = cartService.GetCartProducts();
            if (cartProductsStrings != null)
            {
                Console.WriteLine("Input 1:");
                foreach (var d in cartProductsStrings)
                {
                    Console.WriteLine(d);
                }
            }

            Console.WriteLine("\n");

            var cartDescriptionStrings = cartService.GetCartSummary();
            if (cartDescriptionStrings != null)
            {
                Console.WriteLine("Output 1:");
                foreach (var d in cartDescriptionStrings)
                {
                    Console.WriteLine(d);
                }

            }
        }

        public static void Case2()
        {
            CartService cartService = new CartService();

            cartService.InitCart();
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "imported box of chocolates", Imported = true, Price = new PriceInfo(10), Type = ProductType.Food }, Quantity = 1 });
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "imported bottle of perfume", Imported = true, Price = new PriceInfo(47.50), Type = ProductType.Other }, Quantity = 1 });

            var cartProductsStrings = cartService.GetCartProducts();
            if (cartProductsStrings != null)
            {
                Console.WriteLine("Input 2:");
                foreach (var d in cartProductsStrings)
                {
                    Console.WriteLine(d);
                }
            }

            Console.WriteLine("\n");

            var cartDescriptionStrings = cartService.GetCartSummary();
            if (cartDescriptionStrings != null)
            {
                Console.WriteLine("Output 2:");
                foreach (var d in cartDescriptionStrings)
                {
                    Console.WriteLine(d);
                }

            }
        }

        public static void Case3()
        {
            CartService cartService = new CartService();

            cartService.InitCart();
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "imported bottle of perfume", Imported = true, Price = new PriceInfo(27.99), Type = ProductType.Other }, Quantity = 1 });
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "bottle of perfume", Price = new PriceInfo(18.99), Type = ProductType.Other }, Quantity = 1 });
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "packet of headache pills", Price = new PriceInfo(9.75), Type = ProductType.Medical }, Quantity = 1 });
            cartService.AddProductToCart(new CartProduct() { Product = new Product() { Name = "imported box of chocolates", Imported = true, Price = new PriceInfo(11.25), Type = ProductType.Food }, Quantity = 1 });

            var cartProductsStrings = cartService.GetCartProducts();
            if (cartProductsStrings != null)
            {
                Console.WriteLine("Input 3:");
                foreach (var d in cartProductsStrings)
                {
                    Console.WriteLine(d);
                }
            }

            Console.WriteLine("\n");

            var cartDescriptionStrings = cartService.GetCartSummary();
            if (cartDescriptionStrings != null)
            {
                Console.WriteLine("Output 3:");
                foreach (var d in cartDescriptionStrings)
                {
                    Console.WriteLine(d);
                }

            }
        }

        static void Main(string[] args)
        {

            Case1();
            Console.WriteLine("___________________________________________________");
            Case2();
            Console.WriteLine("___________________________________________________");
            Case3();

        }
    }
}
