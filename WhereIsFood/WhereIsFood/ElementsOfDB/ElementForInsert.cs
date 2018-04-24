using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public abstract class ElementForInsert
    {
        #region Fields
        protected string _commandText;
        #endregion

        #region Properties
        public string CommandText { get { return _commandText; } }
        #endregion
    }
}