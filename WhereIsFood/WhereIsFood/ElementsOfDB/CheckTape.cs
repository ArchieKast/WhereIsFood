using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public class CheckTape : ElementForInsert
    {
        #region Fields
        private int _purchase_id;
        private int _product_id;
        private int _amount;
        #endregion

        #region Constructors
        public CheckTape(int purchase_id, int product_id, int amount)
        {
            _purchase_id = purchase_id;
            _product_id = product_id;
            _amount = amount;
            _commandText = "insert into check_tape(purchase_id, product_id, amount) values("+ purchase_id + ", " + product_id + ", " + amount + ")";
        }
        #endregion
    }
}