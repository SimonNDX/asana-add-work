using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;

namespace Asana_0._1
{
   

    public class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Puttask());

            
        }

        public IRestResponse PUTtask()
        {

           
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://app.asana.com/api/1.0/tasks");

            RestRequest request = new RestRequest();
            request.AddHeader("Authorization", "Bearer "+ Puttask.API);
            request.AddParameter("workspace", "19703882908069");
            request.AddParameter("projects", "685999531555465");
            request.AddParameter("name", "Plats: xx - " + Puttask.NAME + ", FA:xx");
            request.AddParameter("completed", "false");
            request.AddParameter("notes",  "Tel: " + Puttask.TEL + "\nE-Post: " + Puttask.MAIL + "\nLösenord: "+Puttask.PASS+"\nKund Tagit med: "+Puttask.COMP+"  \n\nÄrendet gäller: " + Puttask.TASK);
            request.Method = Method.POST;
            return client.Execute(request);
            
        }
    }
}
