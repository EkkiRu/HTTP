using FluentFTP;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace HttpTest
{
    class Program
    {
        static async void Main(string[] args)
        {
            //Доделать HTTP клиент со всеми доступными методами из практической работы.

            /*var getRequest = HttpWebRequest.Create("https://postman-echo.com/get?foo1=bar1&foo2=bar2");
            getRequest.Method = "GET";
            //getRequest.Headers.Add(...)

            var getResponce = getRequest.GetResponse();

            using (var stream =new StreamReader(getResponce.GetResponseStream()))
            {
                Console.WriteLine(stream.ReadToEnd());
            }

            getResponce.Close();*/

            /*var getRequest = HttpWebRequest.Create($"https://jsonplaceholder.typicode.com/posts/");
            getRequest.Method = "POST";
            var data = Encoding.UTF8.GetBytes();
            var getResponce = await getRequest.GetRequestStreamAsync();
            await getResponce.WriteAsync(data, 0, data.Length);

            Console.WriteLine(((HttpWebResponse)getRequest.GetResponse()).StatusDescription);

            getResponce.Dispose();*/

            /*var getRequest = HttpWebRequest.Create($"https://jsonplaceholder.typicode.com/posts/");
            getRequest.Method = "PUT";
            var data = Encoding.UTF8.GetBytes();
            var getResponce = await getRequest.GetRequestStreamAsync();
            await getResponce.WriteAsync(data, 0, data.Length);

            Console.WriteLine(((HttpWebResponse)getRequest.GetResponse()).StatusDescription);

            getResponce.Dispose();*/


            #region ftp 
            /*var client = new FtpClient("ftp://ftp.dlptest.com/", new NetworkCredential("dlpuser@dlptest.com", "eUj8GeW55SvYaswqUyDSm5v6N"));

            client.Connect();

            foreach(var item in client.GetListing())
            {
                Console.WriteLine(item.FullName);
            }

            client.Disconnect();
            */
            #endregion
        }
    }
}