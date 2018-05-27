using System;
using System.Collections.Generic;
using Npgsql;
using WhereIsProduct.ElementsOfDB;
using WhereIsProduct.Sites;
using System.Data.Common;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WhereIsProduct
{
    public class WorkWithDB
    {
        #region Fields
        private NpgsqlConnection _conn = new NpgsqlConnection("Server=localhost;Port=5432;User=postgres;Password=root;Database=course_project;");
        #endregion

        #region Methods
        public void Open()
        {
            _conn.Open();
        }

        public void Close()
        {
            _conn.Close();
        }

        public int Insert(ElementForInsert element)
        {
            NpgsqlCommand command = new NpgsqlCommand(element.CommandText, _conn);
            int id = 0;
            try
            {
                id = Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                id = 0;
            }
            return id;
        }

        public void Fill(Site site)
        {
            List<int> productsId = new List<int>();
            foreach (var product in  site.GetProducts())
            {
                try
                {
                    Insert(new Category(product.Category));
                }
                catch {}
                productsId.Add(Insert(product));
            }
            foreach (var shop in site.GetShops())
            {
                try
                {
                    Insert(new City(shop.City));
                }
                catch {}
                int shopId = Insert(shop);
                foreach (var productId in productsId)
                {
                    Insert(new Availabity(productId, shopId));
                }
            }
            Console.WriteLine("Вставка завершена!");
        }

        public JArray Find(string substring)
        {
            string commandText = "select * from products where product_name ~* '.*" + substring + "*.';";
            NpgsqlCommand command = new NpgsqlCommand(commandText, _conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            JArray jsonArray = new JArray();
            var count = 0;
            foreach (DbDataRecord item in reader)
            {
                JObject jsonItem = new JObject();
                jsonItem.Add("product_name", item["product_name"].ToString());
                jsonItem.Add("category_name", item["category_name"].ToString());
                jsonItem.Add("cost", item["cost"].ToString());
                jsonArray.Add(jsonItem);
                count++;
            }
            JObject jItem = new JObject();
            jItem.Add("count", count);
            jsonArray.AddFirst(jItem);
            return reader.HasRows ? jsonArray : null;
        }
        #endregion
    }
}