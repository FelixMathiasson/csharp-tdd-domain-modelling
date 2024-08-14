using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> items = new Dictionary<string, int>();

        public bool Add(string product, int price)
        {
            if (items.Keys.Contains(product))
            {
                return false;
            }
            items.Add(product, price);
            return true;
        }




        public int Total()
        {
            int total = 0;
            foreach (var key in items)
            {
                total += key.Value;
            }
            return total;
        }






        public Dictionary<string, int> GetItems() {return items;}

       
    }
}
