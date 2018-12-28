using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace VadAUTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conectareButton_Click(object sender, EventArgs e)
        {
            LogIn client = new LogIn();
            client.command = "Login";
            client.user = userBox.Text;
            client.pass = parolaBox.Text;

           









         //   conectarea Internet


            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:50599/api/LogIn");
            httpWebRequest.ContentType = "appication / json";
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";

            httpWebRequest.Method = "POST";




            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(client);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
               
                string awnser= JsonConvert.DeserializeObject<string>(result);
               
                if (awnser=="ok")
                {
                    MeniuPrincipal meniu = new MeniuPrincipal();
                    meniu.Show();
                    this.Hide();

                }
            }
          


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    class LogIn
        {
            public string command;
            public string user;
            public string pass;
        }
    class Result
    {
        public string result;
    }
}
