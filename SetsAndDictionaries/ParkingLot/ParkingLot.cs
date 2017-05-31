using System;
using System.Collections.Generic;

namespace ParkingLot
{
    public class ParkingLot
    {
        public static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var carNumbersList=new SortedSet<string>();

            while (inputLine!="END")
            {
                var inputParts=inputLine.Split(new []{", "},StringSplitOptions.RemoveEmptyEntries);

                var command = inputParts[0];
                var carNumber = inputParts[1];

                if (command=="IN")
                {
                    carNumbersList.Add(carNumber);
                }
                else
                {
                    carNumbersList.Remove(carNumber);
                }

                inputLine = Console.ReadLine();
            }

            if (carNumbersList.Count>0)
            {
                foreach (var number in carNumbersList)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
