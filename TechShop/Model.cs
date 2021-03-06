using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TechShop
{
    public class Model
    {
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
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
    public class Order
    {
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public int seller_id { get; set; }
        public DateTime sold_date { get; set; }
        public int total_money   { get; set; }
    }
    public class OrderDetail
    {
        public int orderdetail_id { get; set; }
        public int product_id { get; set; }
        public int order_id { get; set; }
        public int quantity { get; set; }
    }
    public class User
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public int role_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
    public class Brand
    {
        public int brand_id { get; set; }
        public string name { get; set; }
    }
    public class Category
    {
        public int category_id { get; set; }
        public string name { get; set; }
    }
    public class Insurance
    {
        public int insurance_id { get; set; }
        public string time { get; set; }
    }
}
