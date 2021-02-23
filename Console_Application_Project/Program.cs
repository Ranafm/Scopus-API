using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using API_framework.Entites;

namespace API_framework
{
    public class Program
    {
         static List<entry> journals = new List<entry>();
        static void Main(string[] args)
        {
           Console.WriteLine("main function");
         //   RunAsync().Wait();
            // List<entry> x = Liststring();
            //Console.WriteLine(x + "here the main");

        }

        public static async Task RunAsync()
        { int count = 5;
            using (var client = new HttpClient())
            {
                Console.WriteLine("RunAsync function");
                client.BaseAddress = new Uri("http://localhost:8000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET the response
               //Read the documentation to add query params
                HttpResponseMessage response = await client.GetAsync("https://api.elsevier.com/content/serial/title?apikey="hereAPIkey"&httpAccept=application/json");
               
                //TODO: into json
                JObject journal = JObject.Parse(await response.Content.ReadAsStringAsync());

                //Loop over the objects
                for (int i = 0; i < count; i++)
                {
                    //Console.WriteLine(i);
                    // Edit here based on the data needed
                    string title = (string)journal["serial-metadata-response"]["entry"][i]["dc:title"];
                    string subject = (string)journal["serial-metadata-response"]["entry"][i]["subject-area"][0]["@abbrev"];
                    string link = (string)journal["serial-metadata-response"]["entry"][i]["link"][0]["@href"];
                    //Add the data into a list 
                    journals.Add(new entry { name = title, subject = subject, link = link });
                }


                //TODO: write the data in the journals list
                //To check ..
                foreach (entry journal in journals)
                {

                    Console.WriteLine($"Title: {journal.name}\n The subject area : {journal.subject}\n Journal Link:{journal.link} \n\n ---- \n");
                }

            }
        }
//Return List of object type entry 
   public static List<entry> Liststring()
        {
            RunAsync().Wait();
            List<entry> titles = new List<entry>();
            Console.WriteLine("-- here return function ---");
            //Console.WriteLine(journals);
            foreach (entry journal in journals)
            {
                titles.Add(new entry { name = journal.name, subject = journal.subject, link = journal.link });
            }

            foreach (entry a in titles)
            {
                Console.WriteLine("-@@@- here titles form list string -@@@-");
                Console.WriteLine($"Titles: {a.name}\n The subject area : {a.subject}\n Journal Link:{a.link} \n\n ---- \n");
            }

            Console.WriteLine(titles + "here the titles log");
            return titles;
        }

    }

}
