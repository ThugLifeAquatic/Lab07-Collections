using System;

namespace Lab07Austin
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory<Product> myCart = new Inventory<Product>();
            Inventory<Product> myProducts = new Inventory<Product>
            {
                new Product() { ProdName = "Pass-the-Butter Robot", Category = ProductType.HouseWares },
                new Product() { ProdName = "Mega-Seeds", Category = ProductType.Consumables },
                new Product() { ProdName = "Plumbus", Category = ProductType.HouseWares },
                new Product() { ProdName = "Fleeb", Category = ProductType.Magical },
                new Product() { ProdName = "PortalGun Fluid", Category = ProductType.Consumables }
            };

            myProducts.Add(new Product() { ProdName = "Microverse Battery", Category = ProductType.Auto });
            myProducts.Add(new Product() { ProdName = "Meeseeks Box", Category = ProductType.Magical });
            myProducts.Add(new Product() { ProdName = "Interdimensional Cable-Box", Category = ProductType.Electronics });
            myProducts.Add(new Product() { ProdName = "Pickles", Category = ProductType.Consumables });
            myProducts.Add(new Product() { ProdName = "Eye-Holes Breakfast Cereal", Category = ProductType.Consumables });
            myProducts.Add(new Product() { ProdName = "DingleHopper", Category = ProductType.Gadgets });

            Console.WriteLine("Welcome to Salesman Ricks Multidimensional Internet Emporium!");
            Console.WriteLine("I got all sorts of usefull stuff. Check me out!");
            Console.WriteLine();
            StoreLoop(myProducts, myCart);

        }

        public static void StoreLoop(Inventory<Product> inventory, Inventory<Product> cart)
        {
            Console.Clear();
            Inventory<Product> myCart = new Inventory<Product>();
            Inventory<Product> saveShop = inventory;
            Inventory<Product> saveCart = myCart;
            int index = 0;
            int cartIndex = 0;
            Console.WriteLine("Welcome to Salesman Ricks Multidimensional Internet Emporium!");
            Console.WriteLine();

            Console.WriteLine("I got all sorts of usefull stuff.");
            Console.WriteLine("Simply Enter a number to buy the corresponding item.");
            Console.WriteLine("I'm Salesman Rick! Check me out!");

            Console.WriteLine();
            try
            {
                foreach (Product item in inventory)
                {
                    Console.WriteLine($"{index}): ITEM: {item.ProdName} - {item.Category}");
                    index++;
                }
                Console.WriteLine();
                Console.WriteLine("Your Cart:");
                Console.WriteLine();

                foreach (Product item in cart)
                {
                    Console.WriteLine($"{cartIndex}): ITEM: {item.ProdName} - {item.Category}");
                    cartIndex++;
                }

                int input = Convert.ToInt32(Console.ReadLine());

                cart.Add(inventory.Remove(input));
                StoreLoop(inventory, cart);
            }
            catch (Exception)
            {
                Console.WriteLine("That was not a valid option. Press enter to continue.");
                StoreLoop(saveShop, saveCart);
            }
        }
    }
}
