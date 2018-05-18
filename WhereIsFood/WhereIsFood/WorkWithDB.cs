using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;
using WhereIsProduct.ElementsOfDB;
using WhereIsProduct.Sites;

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
            return Convert.ToInt32(command.ExecuteScalar());
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
                finally
                {
                    productsId.Add(Insert(product));
                }
            }
            foreach (var shop in site.GetShops())
            {
                try
                {
                    Insert(new City(shop.City));
                }
                finally
                {
                    int shopId = Insert(shop);
                    foreach (var productId in productsId)
                    {
                        Insert(new Availabity(productId, shopId));
                    }
                }
            }
        }
        #endregion
    }
}