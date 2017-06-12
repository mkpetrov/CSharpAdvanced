using System;

namespace Students_Results
{
    class StudentsResults
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|","Name","CAdv","COOP","AdvOOP","Average");

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new []{' ','-',','},StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];
                var firstNum = double.Parse(input[1]);
                var secondNum = double.Parse(input[2]);
                var thirdNum = double.Parse(input[3]);
                var average = (firstNum + secondNum + thirdNum) / 3;

                Console.WriteLine("{0,-10:f2}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",name,firstNum,secondNum,thirdNum,average);
            }
        }
    }
}
