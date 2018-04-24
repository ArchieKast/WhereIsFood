using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;
using HtmlAgilityPack;
using WhereIsFood.ElementsOfDB;

namespace WhereIsFood
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithDB db = new WorkWithDB();
            db.Open();

            Console.ReadKey();
            db.Close();
        }
    }
}