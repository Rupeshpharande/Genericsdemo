using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsdemo
{
    public class GetPrice : Comparer<ProductComparabledemo>
    {
        public override int Compare(ProductComparabledemo x, ProductComparabledemo y)
        {
           if(x.Price>y.Price)
            {
                return 1;

            }
           else if(x.Price < y.Price)
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
