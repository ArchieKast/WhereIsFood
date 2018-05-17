using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public struct DataFrame
    {
        #region Fields
        private List<Product> _products;
        private List<Shop> _shops;
        #endregion

        #region Properties
        public List<Product> Products { get { return _products; } }
        public List<Shop> Shops { get { return _shops; } }
        #endregion

        #region Constructors
        public DataFrame(List<Product> products, List<Shop> shops)
        {
            _products = new List<Product>(products);
            _shops = new List<Shop>(shops);
        }
        #endregion
    }
}