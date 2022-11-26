using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armwrest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public string[] adlar;
        int yarisciSay, indis = 0;
        private void btnqeyd_Click(object sender, EventArgs e)
        {
            yarisciSay = Convert.ToInt32(numericUpDown1.Value);
            adlar = new string[yarisciSay];
            MessageBox.Show(yarisciSay + " Yarisci sayi qeyd edildi ");
        }
        private void btnelave_Click(object sender, EventArgs e)
        {
            if (indis<yarisciSay)
            {
                adlar[indis] = txtadi.Text;
                
               // MessageBox.Show( txtadi.Text + " Elave edildi ");
                indis++;                
            }

            else if (true)
            {
               
                foreach (var item in adlar)
                {
                    MessageBox.Show(item + " Elave edildi ");
                }
            }          
            else
            {
                MessageBox.Show(yarisciSay + " dene ad qeyd etdiniz, \nzehmet olmasa qeyd etdiyiniz sayi artirin");
            }
        }
        Random rastgele = new Random();
        int saygac = 1;

        private void Btnbasla_Click(object sender, EventArgs e)
        {
            List.Items.Add(saygac + " " + adlar[rastgele.Next(0, yarisciSay)]);
            saygac++;
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            saygac = 1;
        }
    }
}
