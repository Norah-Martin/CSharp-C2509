using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Assigment13
{
    public class Download
    {

     
        public static async Task DownloadDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Console.WriteLine("Started to download");
                    string data = await client.GetStringAsync(url);
                    //Gets data.
                    Console.WriteLine("Download complete. Length: " + data.Length);
                    //Displays length of data.
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                }
                //Catch http request exception.
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
                //Catching other exceptions.
            }
        }
        public static async void Call(string url)
        {
            await DownloadDataAsync(url);
        }


    }
}
