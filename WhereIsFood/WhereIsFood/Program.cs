using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;

namespace WhereIsFood
{
    class Program
    {
        static void Main(string[] args)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User=postgres;Password=root;Database=course_project;");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("select * from purchases", conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                foreach (DbDataRecord record in reader)
                    Console.WriteLine(record["purchase_id"]);
            }
            else
                Console.WriteLine("Запрос не вернул строк");
            Console.ReadKey();
        }
    }
}
