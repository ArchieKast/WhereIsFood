using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public class ShoppingList : ElementForInsert
    {
        #region Fields
        private int _account_id;
        private int _purchase_id;
        #endregion

        #region Constructors
        public ShoppingList(int account_id, int purchase_id)
        {
            _account_id = account_id;
            _purchase_id = purchase_id;
            _commandText = "insert into shopping_list(account_id, purchase_id) values(" + account_id + ", " + purchase_id + ")";
        }
        #endregion
    }
}