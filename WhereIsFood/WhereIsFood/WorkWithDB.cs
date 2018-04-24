using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;
using WhereIsFood.ElementsOfDB;

namespace WhereIsFood
{
    public class WorkWithDB
    {
        #region Fields
        private NpgsqlConnection _conn = new NpgsqlConnection("Server=localhost;Port=5432;User=postgres;Password=root;Database=course_project;");
        #endregion

        #region Methods
        public void Open()
        {
            _conn.Open();
        }

        public void Close()
        {
            _conn.Close();
        }

        public void Insert(ElementForInsert element)
        {
            NpgsqlCommand command = new NpgsqlCommand(element.CommandText, _conn);
            NpgsqlDataReader reader = command.ExecuteReader();
        }
 
        #endregion
    }
}