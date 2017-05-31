using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var vipList=new SortedSet<string>();
            var regularList=new SortedSet<string>();

            while (input!="PARTY")
            {
                if (input[0]>=48 && input[0]<=57)
                {
                    vipList.Add(input);
                }
                else
                {
                    regularList.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input!="END")
            {
                if (input[0] >= 48 && input[0] <= 57)
                {
                    vipList.Remove(input);
                }
                else
                {
                    regularList.Remove(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(vipList.Count+regularList.Count);
            foreach (var vip in vipList)
            {
                Console.WriteLine(vip);
            }

            foreach (var regular in regularList)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
