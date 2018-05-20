using System;
using WhereIsProduct.Sites;

namespace WhereIsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithDB db = new WorkWithDB();
            db.Open();

            //AlphabetOfTaste site = new AlphabetOfTaste("https://av.ru");
            //db.Fill(site);

            Console.ReadKey();
            db.Close();
        }
    }
}