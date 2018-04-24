using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public class Purchase : ElementForInsert
    {
        #region Constructors
        public Purchase()
        {
            _commandText = "insert into purchases(purchase_id) values(default)";
        }
        #endregion
    }
}