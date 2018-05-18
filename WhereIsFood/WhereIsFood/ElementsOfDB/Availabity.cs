using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsProduct.ElementsOfDB
{
    public class Availabity : ElementForInsert
    {
        #region Fields
        private int _product_id;
        private int _shop_id;
        #endregion

        #region Properties
        public int ProductId { get { return _product_id; } }
        public int ShopId { get { return _shop_id; } }
        #endregion

        #region Constructors
        public Availabity(int product_id, int shop_id)
        {
            _product_id = product_id;
            _shop_id = shop_id;
            _commandText = "insert into availability(product_id, shop_id) values(" + product_id + ", " + shop_id + ");";
        }
        #endregion
    }
}