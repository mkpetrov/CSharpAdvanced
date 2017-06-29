namespace _01.SecondNatureV2

{

    using System;

    using System.Collections.Generic;

    using System.Linq;



    public static class Program

    {

        private static List<int> secondNatureFlowers = new List<int>();



        public static void Main()

            namespace _01.SecondNatureV2

        {

            using System;

            using System.Collections.Generic;

            using System.Linq;



        public static class Program

        {

            private static List<int> secondNatureFlowers = new List<int>();



            public static void Main()

            {

                var flowers = Console.ReadLine()

                    .Split(' ')

                    .Select(int.Parse)

                    .ToList();



                var buckets = new Stack<int>(Console.ReadLine()

                    .Split(' ')

                    .Select(int.Parse));



                var flowerIndex = 0;

                while (buckets.Any() && flowerIndex < flowers.Count)

                {

                    var currentBucket = buckets.Peek();

                    var currentFlower = flowers[flowerIndex];



                    if (currentBucket == currentFlower)

                    {

                        secondNatureFlowers.Add(currentFlower);

                        buckets.Pop();

                        flowerIndex++;

                    }

                    else

                    {

                        flowers[flowerIndex] -= currentBucket;

                        if (flowers[flowerIndex] <= 0)

                        {

                            flowers.RemoveAt(flowerIndex);

                            var remainingWater = buckets.Pop() - currentFlower;

                            if (buckets.Any())

                            {

                                remainingWater += buckets.Pop();

                            }



                            buckets.Push(remainingWater);

                        }

                        else

                        {

                            buckets.Pop();

                        }

                    }

                }



                Console.WriteLine(buckets.Any() ? string.Join(" ", buckets) : string.Join(" ", flowers));

                Console.WriteLine(secondNatureFlowers.Any() ? string.Join(" ", secondNatureFlowers) : "None");

            }

        }

    }{

            var flowers = Console.ReadLine()

                .Split(' ')

                .Select(int.Parse)

                .ToList();



            var buckets = new Stack<int>(Console.ReadLine()

                .Split(' ')

                .Select(int.Parse));



            var flowerIndex = 0;

            while (buckets.Any() && flowerIndex < flowers.Count)

            {

                var currentBucket = buckets.Peek();

                var currentFlower = flowers[flowerIndex];



                if (currentBucket == currentFlower)

                {

                    secondNatureFlowers.Add(currentFlower);

                    buckets.Pop();

                    flowerIndex++;

                }

                else

                {

                    flowers[flowerIndex] -= currentBucket;

                    if (flowers[flowerIndex] <= 0)

                    {

                        flowers.RemoveAt(flowerIndex);

                        var remainingWater = buckets.Pop() - currentFlower;

                        if (buckets.Any())

                        {

                            remainingWater += buckets.Pop();

                        }



                        buckets.Push(remainingWater);

                    }

                    else

                    {

                        buckets.Pop();

                    }

                }

            }



            Console.WriteLine(buckets.Any() ? string.Join(" ", buckets) : string.Join(" ", flowers));

            Console.WriteLine(secondNatureFlowers.Any() ? string.Join(" ", secondNatureFlowers) : "None");

        }

    }

}