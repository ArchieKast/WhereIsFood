using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public class Category : ElementForInsert
    {
        #region Fields
        private string _name;
        #endregion

        #region Constructors
        public Category(string name)
        {
            _name = name;
            _commandText = "insert into categories(category_name) values('" + name + "');";
        }
        #endregion
    }
}