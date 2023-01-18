using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InventoryManagement
{
    class Program
    {

        public static void Main(string[] args)
        {
            string Path = "C:\\Users\\sande\\source\\repos\\246\\InventoryManagement\\InventoryManagement\\Search.json";

            ReadData readData = new ReadData();
            var Info = readData.Read(Path);

            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Stock is:");
            Console.WriteLine("--------------------");
            for (int i = 0; i < Info.typesOfStock.Count; i++)
            {
                Console.WriteLine("Name: " + Info.typesOfStock[i].name);
                Console.WriteLine("NoOfshare: " + Info.typesOfStock[i].NoOfshare);
                Console.WriteLine("price: " + Info.typesOfStock[i].price);

                int val = Info.typesOfStock[i].NoOfshare * Info.typesOfStock[i].price;
                Console.WriteLine("The price for " + Info.typesOfStock[i].NoOfshare + " Stock is " + val);
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");


        }
    }
        }
    

