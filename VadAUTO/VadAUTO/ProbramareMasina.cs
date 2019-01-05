using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VadAUTO
{
    public partial class ProbramareMasina : UserControl
    {
        public ProbramareMasina()
        {
            InitializeComponent();
        }

        private void programeazaButton_Click(object sender, EventArgs e)
        {
            Programare programare = new Programare();

            adaugareDate(programare, numeText.Text, prenumeText.Text, automobilText.Text, dateTimePicker1.Text);
            string json = JsonConvert.SerializeObject(programare);
        }
        public void adaugareDate(Programare programare,string name,string surname,string car ,string date)
        {
            programare.nume = name;
            programare.prenume = surname;
            programare.masina = car;
            programare.ziua_programari = date;
        }
        public class Programare
        {
            public string command = "programare";
            public string nume;
            public string prenume;
            public string masina;
            public string ziua_programari;
        }
    }
}
