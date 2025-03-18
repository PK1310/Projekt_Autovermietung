using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovermietung2030
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Kundenliste_Click(object sender, EventArgs e)
        {
            Kundenliste kundenliste = new Kundenliste();
            kundenliste.Show();
        }
        private void btn_Einzelansicht_Click(object sender, EventArgs e)
        {
            Kundeneinzel kundeneinzel = new Kundeneinzel();
            kundeneinzel.Show();
        }

        private void btn_Fahrzeugliste_Click(object sender, EventArgs e)
        {
            Fahrzeug_Liste fahrzeugListe = new Fahrzeug_Liste();
            fahrzeugListe.Show();
        }

        private void btn_FahrzeugEinzeln_Click(object sender, EventArgs e)
        {
            
            Fahrzeug_Einzel fahrzeugEinzel = new Fahrzeug_Einzel();
            fahrzeugEinzel.Show();
        }
    }
}
