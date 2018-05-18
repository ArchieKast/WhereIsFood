using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsProduct.ElementsOfDB
{
    public class Account : ElementForInsert
    {
        #region Fields
        private string _nickname;
        private string _password;
        private string _full_name;
        #endregion

        #region Properties
        public string Nickname { get { return _nickname; } }
        public string FullName { get { return _full_name; } }
        #endregion

        #region Constructors
        public Account(string nickname, string password, string full_name = null)
        {
            _nickname = nickname;
            _password = password;
            _full_name = full_name;
            _commandText = "insert into accounts(account_id, nickname, password, full_name) values(default, '" + nickname + "', '" + password + "', ";
            _commandText += full_name == null ? "null" + ");" : "'" + full_name + "');";
        }
        #endregion
    }
}