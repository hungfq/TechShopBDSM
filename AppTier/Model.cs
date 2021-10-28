using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTier
{
    public class Product
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string image { get; set; }
        public int brand_id { get; set; }
        public int category_id { get; set; }

        public int insurance_id { get; set; }
    }
    public class Customer
    {
        public int customer_id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string phone_number { get; set; }
    }
    class Model
    {
    }
}
