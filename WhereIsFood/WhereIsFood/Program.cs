using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;
using HtmlAgilityPack;
using WhereIsProduct.ElementsOfDB;
using WhereIsProduct.Sites;

namespace WhereIsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithDB db = new WorkWithDB();
            db.Open();

            AlphabetOfTaste site = new AlphabetOfTaste("https://av.ru");
            db.Fill(site);

            Console.ReadKey();
            db.Close();
        }
    }
}