using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace WhereIsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithDB db = new WorkWithDB();
            db.Open();

            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://127.0.0.1:3000/");
            listener.Start();
            Console.WriteLine("Ожидание подключений...");
            try
            {
                while (true)
                {
                    HttpListenerContext context = listener.GetContext();
                    HttpListenerRequest request = context.Request;
                    Stream body = request.InputStream;
                    System.Text.Encoding encoding = request.ContentEncoding;
                    StreamReader reader = new StreamReader(body, encoding);
                    var data = db.Find(reader.ReadToEnd());

                    HttpListenerResponse response = context.Response;
                    response.ContentType = "application/json";
                    response.AddHeader("Access-Control-Allow-Origin", "*");
                    string serialized = JsonConvert.SerializeObject(data);
                    byte[] buffer = Encoding.UTF8.GetBytes(serialized);
                    response.ContentLength64 = buffer.Length;
                    Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                listener.Stop();
                Console.ReadKey();
                db.Close();
            }
        }
    }
}