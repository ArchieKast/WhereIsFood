using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.ElementsOfDB
{
    public class Shop : ElementForInsert
    {
        #region Fields
        private string _name;
        private string _adress;
        private string _city;
        #endregion

        #region Properties
        public string City { get { return _city; } }
        #endregion

        #region Constructors
        public Shop(string name, string adress, string city)
        {
            _name = name;
            _adress = adress;
            _city = city;
            _commandText = "insert into shops(shop_id, shop_name, adress, city_name) values(default, '" + name + "', '" + adress + "', '" + city + "') returning shop_id;";
        }
        #endregion
    }
}