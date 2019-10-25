using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> lista = new List<string>();
        //public List<string> hobbik = new List<string>();

        public string neme = "";
        public string hiba = "";
        public int index = 0;


        private void kedvencLabel_Click(object sender, EventArgs e)
        {

        }

        private void nButton_click(object sender, EventArgs e)
        {

        }

        private void nevLabel_Click(object sender, EventArgs e)
        {

        }

        private void mentesButton_Click(object sender, EventArgs e)
        {
            

            using (var sw = new StreamWriter("kimenet.txt"))
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    sw.WriteLine(lista[i]);
                }
                
            }


        }

        private void hozzaadButton_Click(object sender, EventArgs e)
        {
            if (nButton.Checked==true && fButton.Checked==false)
            {
                neme = "Nő";
            }
            else if (fButton.Checked == true && nButton.Checked == false)
            {
                neme = "Férfi";
            }
            else
            {
                hiba = "hiba";
            }


            lista.Add(nevText.Text + "; " + szuldatText.Text + "; " + neme + "; " + ujhobbiText.Text);

            kedvenclistbox.Items.Add(lista[index]);
            index++;

        }

        private void kedvencText_TextChanged(object sender, EventArgs e)
        {

        }

        private void kedvenclistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void betoltesButton_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader("kimenet.txt");
            string sor;
            while (true)
            {
                sor = sr.ReadLine();
                if (sor == null)
                {
                    break;
                }
                //Console.WriteLine("Sor: " + sor);
                kedvenclistbox.Items.Add(sor);
            }

            
        }
    }
}
