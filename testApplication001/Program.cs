using System;

namespace testApplication001
{
    class Program
    {
        static void Main(string[] args)
        {
            // D&R'a girip karşıma çıkan oyunları yaptım.
            Product product1 = new Product();
            product1.productName = "Cyberpunk 2077 - PS4";
            product1.productProcessor = "Playstation 4";
            product1.productPrice = 599;

            Product product2 = new Product();
            product2.productName = "Just Dance 2021";
            product2.productProcessor = "Playstation 4";
            product2.productPrice = 550;

            Product product3 = new Product();
            product3.productName = "Football Manager 2021";
            product1.productProcessor = "PC - DVD-Rom";
            product3.productPrice = 250;


            Product[] products = new Product[] { product1, product2, product3 };
            // For ile ekrana yazdırıyorum

            Console.WriteLine("For ile yazdırma başladı.");

            for (int s = 0; s < products.Length; s++)
            {
                Console.WriteLine(products[s].productName + " : " + products[s].productProcessor + " : " + products[s].productPrice);
            }

            Console.WriteLine("For ile yazdırma bitti.");

            // Foreach ile ekrana yazdırıyorum

            Console.WriteLine("Foreach ile yazdırma başladı.");

            foreach (var product in products)
            {
                Console.WriteLine(product.productName + " : " + product.productProcessor + " : " + product.productPrice);
            }

            Console.WriteLine("Foreach ile yazdırma bitti.");

            // While ile ekrana yazdırıyorum.

            Console.WriteLine("While ile yazdırma başladı.");

            int semih = 0;
            while (semih < products.Length)
            {
                Console.WriteLine(products[semih].productName + " : " + products[semih].productProcessor + " : " + products[semih].productPrice);
                semih++;
            }

            Console.WriteLine("While ile yazdırma bitti.");
        }
    }
    class Product
    {
        public string productName { get; set; }
        public string productProcessor { get; set; }
        public int productPrice { get; set; }
    }
}