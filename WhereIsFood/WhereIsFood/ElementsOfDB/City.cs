using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public class City : ElementForInsert
    {
        #region Fields
        private string _name;
        #endregion

        #region Constructors
        public City(string name)
        {
            _name = name;
            _commandText = "insert into cities(city_name) values('" + name + "')";
        }
        #endregion
    }
}