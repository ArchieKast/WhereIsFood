using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public class Product : ElementForInsert 
    {
        #region Fields
        private string _name;
        private double _cost;
        private string _category;
        #endregion

        #region Constructors
        public Product(string name, double cost, string category)
        {
            _name = name;
            _cost = cost;
            _category = category;
            _commandText = "insert into products(product_id, product_name, cost, category) values(default, '" + name + "', " + cost.ToString().Replace(',', '.') + ", '" + category + "')";
        }
        #endregion
    }
}