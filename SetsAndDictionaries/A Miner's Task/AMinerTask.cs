using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_s_Task
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var resource = Console.ReadLine();

            var resourcesInfo=new Dictionary<string,long>();

            while (resource!="Stop")
            {
                var quantity = long.Parse(Console.ReadLine());

                if (!resourcesInfo.ContainsKey(resource))
                {
                    resourcesInfo[resource] = 0;
                }
                resourcesInfo[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var res in resourcesInfo)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
