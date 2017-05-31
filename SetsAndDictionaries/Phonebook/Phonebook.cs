using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var phonebook=new Dictionary<string,string>();

            while (input!="search")
            {
                var inputParts = input.Split('-');

                var name = inputParts[0];
                var number = inputParts[1];

                phonebook[name] = number;


                input = Console.ReadLine();
            }

            var nameSearch = Console.ReadLine();
            while (nameSearch!="stop")
            {
                if (!phonebook.ContainsKey(nameSearch))
                {
                    Console.WriteLine($"Contact {nameSearch} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{nameSearch} -> {phonebook[nameSearch]}");
                }

                nameSearch = Console.ReadLine();
            }
        }
    }
}
