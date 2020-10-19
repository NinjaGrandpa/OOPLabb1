using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var kund = new Customer();
            while (true)
            {
                Console.WriteLine("Do you want to make a purchase?");
                if (Console.ReadLine().ToLower() == "yes")
                {

                    Console.WriteLine("We currently have a special deal on Überbananer. (Write 'überbanan' to access this deal.)");
                    Console.WriteLine("What do you want to buy?");
                    var product = new Product() { _productName = Console.ReadLine()};
                    var specialdeal = new SpecialDeal() {_productName = "überbanan"};
                    kund._cart.Add(product);
                    kund._cart.Add(specialdeal);
                    var askedDeal = false;

                    while (askedDeal!)
                    {
                        if (product._productName == specialdeal._productName)
                        {
                            Console.WriteLine("Congrats, you get a 13% discount on Überbananer");
                            askedDeal = true;
                        }

                        else
                        {
                            Console.WriteLine("Suit yourself, no Überbananer for you.");
                            askedDeal = true;
                        }
                    }

                }
                else
                    break;

                Console.WriteLine("Do you want to view your cart?");
                if (Console.ReadLine().ToLower() == "yes") 
                {
                    foreach (var item in kund._cart)
                    {
                        Console.WriteLine(item._productName);
                    }

                }
                    

                else
                    Console.WriteLine("Suck a duck!");
            }
        }
    }
}
