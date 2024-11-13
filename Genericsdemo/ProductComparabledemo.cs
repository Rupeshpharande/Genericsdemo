using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsdemo
{
     public class ProductComparabledemo:IComparable
    {
        private string name;
        private int price;

        public ProductComparabledemo(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int Price 
        {
           get { return price; }
        }
        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {
            return $" name:{name} price:{price}";
        }


        public int CompareTo(object obj)
        {
            ProductComparabledemo p = (ProductComparabledemo)obj;

            if(this.price>p.price)
            {
                return 1;
            }
            else if(this.price < p.price) 
            {
              return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
