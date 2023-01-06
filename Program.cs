﻿using System;
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

            //Console.WriteLine(Info.typesOfRice.name);
            //Console.WriteLine(Info.typesOfRice.weight);
            //Console.WriteLine(Info.typesOfRice.price);

            //Storing the multiple values of Array in List.
            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Rice is:");
            Console.WriteLine("--------------------");
            for (int i = 0; i < Info.typesOfRice.Count; i++)
            {
                Console.WriteLine(Info.typesOfRice[i].name);
                Console.WriteLine(Info.typesOfRice[i].weight);
                Console.WriteLine(Info.typesOfRice[i].price);

                int val = Info.typesOfRice[i].weight * Info.typesOfRice[i].price;
                Console.WriteLine("The price for" + Info.typesOfRice[i].weight + "kg is" + val);
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Pulses is:");
            Console.WriteLine("--------------------");


            for (int i = 0; i < Info.typesOfPulses.Count; i++)
            {
                Console.WriteLine(Info.typesOfPulses[i].name);
                Console.WriteLine(Info.typesOfPulses[i].weight);
                Console.WriteLine(Info.typesOfPulses[i].price);

                int val = Info.typesOfPulses[i].weight * Info.typesOfPulses[i].price;
                Console.WriteLine("The price for" + Info.typesOfPulses[i].weight + "kg is" + val);
                Console.WriteLine();

            }
            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Wheat is:");
            Console.WriteLine("--------------------");

            for (int i = 0; i < Info.typesOfWheat.Count; i++)
            {
                Console.WriteLine(Info.typesOfWheat[i].name);
                Console.WriteLine(Info.typesOfWheat[i].weight);
                Console.WriteLine(Info.typesOfWheat[i].price);

                int val = Info.typesOfWheat[i].weight * Info.typesOfWheat[i].price;
                Console.WriteLine("The price for" + Info.typesOfWheat[i].weight + "kg is" + val);
                Console.WriteLine();


            }
        }
    }
}
