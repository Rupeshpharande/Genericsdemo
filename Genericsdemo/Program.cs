using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductComparabledemo> list = new List<ProductComparabledemo>();
            list.Add(new ProductComparabledemo("fan", 2000));
            list.Add(new ProductComparabledemo("Table", 1000));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

           //int result= list[0].CompareTo(list[1]);

            GetPrice gt=new GetPrice();
            int result = gt.Compare(list[0], list[1]);

            if (result == 0)
            {
                Console.WriteLine("both have same price");
            }
            else if (result == 1)
            {
                Console.WriteLine($"price of {list[0].Name} is max than {list[1].Name}");
            }
            else
            {
                Console.WriteLine($"price of {list[1].Name} is max than {list[0].Name}");
            }

        }
    }
}
