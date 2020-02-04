using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asana_0._1
{

    public partial class Puttask : Form
    {
       

        public static string NAME = "";
        public static string TEL = "";
        public static string MAIL = "";
        public static string PASS = "";
        public static string TASK = "";
        public static string COMP;
        public static string comp;
        public static bool DIV;
        public static string API;



        public Puttask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program p = new Program();

            NAME = NAMETB.Text;
            TEL = NUMBERTB.Text;
            MAIL = MAILTB.Text;
            TASK = TASKTB.Text;
            PASS = PASSTB.Text;
            API = APIK.Text;

            if (DIV == true)
            {
                COMP = DIVTB.Text;
            }
            else
            {
                COMP = comp;
            }



            Debug.WriteLine(p.PUTtask().Content.ToString());

            string message = "Glöm ej att kund ska signera papper i pärmen på inlämningsdisken";
            string title = "Viktigt!";
            MessageBox.Show(message, title);
        }

        private void CORB_CheckedChanged(object sender, EventArgs e)
        {
            comp = "Endast Dator";
            DIV = false;
        }

        private void COCHRB_CheckedChanged(object sender, EventArgs e)
        {
            comp = "Dator + Laddare";
            DIV = false;
        }

        private void PHRB_CheckedChanged(object sender, EventArgs e)
        {
            comp = "Telefon";
            DIV = false;
        }

        private void PADRB_CheckedChanged(object sender, EventArgs e)
        {
            comp = "Ipad/Surfplatta";
            DIV = false;
        }

        private void DIVRB_CheckedChanged(object sender, EventArgs e)
        {
            DIV = true;
        }

        
    }
}
