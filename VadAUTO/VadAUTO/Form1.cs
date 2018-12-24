using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            string json = JsonConvert.SerializeObject(client);
           
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
}
