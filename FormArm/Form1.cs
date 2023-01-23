using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormArm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Calling OnLoad");
            OnLoad(null);
            Console.WriteLine("Exiting constructor");
        }
        protected override void OnLoad(EventArgs e)
        {
            Console.WriteLine("Enter OnLoad");
            base.OnLoad(e);
            Console.WriteLine("Exit OnLoad");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("In Form1_Load");
        }

        string[] adlar;
        int yarisciSay=default;
        int indis = 0;
        private void btnqeyd_Click(object sender, EventArgs e)
        {

            yarisciSay = Convert.ToInt32(numericUpDown1.Value);
            adlar = new string[yarisciSay];
            MessageBox.Show(yarisciSay + " Yarisci sayi qeyd edildi ");
        }

        private void btnelave_Click(object sender, EventArgs e)
        {
            if (indis < yarisciSay)
            {
                adlar[indis] = txtad.Text;
                if (txtad.Text!="")
                {
                    Yariscilar.Items.Add(txtad.Text);                    
                    txtad.Text = "";
                    txtad.Focus();
                }
                else
                {
                    MessageBox.Show("Birinci Ad Qeyde etmelisiz", "Sehf", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                indis++;
            }
            else
            {
                MessageBox.Show(yarisciSay + " dene ad qeyd etdiniz, \nzehmet olmasa qeyd etdiyiniz sayi artirin");
            }
        }
        int saygac = 1;
        private void btnbasla_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = Yariscilar.Items.Count;
            for (int i = 1; i <= kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, Yariscilar.Items.Count);
                if (i % 2 == 1)
                {
                    List.Items.Add(Yariscilar.Items[tutulan]);
                    Yariscilar.Items.RemoveAt(tutulan);
                }
                else
                {
                    List2.Items.Add(Yariscilar.Items[tutulan]);
                    Yariscilar.Items.RemoveAt(tutulan);
                }               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Int32.Parse(textBox1.Text);
                Random rnd = new Random();
                for (int i = 1; i <= sayi; i++)
                {
                    int tutulan = rnd.Next(0, Yariscilar.Items.Count);
                    List.Items.Add(Yariscilar.Items[tutulan]);
                    Yariscilar.Items.RemoveAt(tutulan);
                }
            }
            catch
            {
                MessageBox.Show("YalniS Isledirsiz");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            Yariscilar.Items.Clear();
            Array.Clear(adlar, 0, adlar.Length);
            saygac = 1;
            if (Application.OpenForms[0] == this)
            {

                Application.Restart();
            }
            else
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
        }
        private void btnsc1_Click(object sender, EventArgs e)
        {
            if (List.SelectedItem!=null)
            {
                Round1.Items.Add(List.SelectedItem);                
            }           
            if (List2.SelectedItem!=null)
            {
                Round1.Items.Add(List2.SelectedItem);
            }           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Round1.SelectedItem!=null)
            {
                Round1.Items.RemoveAt(Round1.SelectedIndex);
            }            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Round1.SelectedIndex!=-1)
            {
                int say = Round1.Items.Count;
                Random rnd = new Random();
                int count = rnd.Next(0, say);
                Round1.SelectedIndex = count;
            }            
        }
        private void btnsc2_Click(object sender, EventArgs e)
        {
            if (Round1.SelectedItems != null && Round1.SelectedIndex!=-1)              
                Round2.Items.Add(Round1.SelectedItem);
            if (Round1.SelectedIndex!=-1)
            {
                int i = 0;
                i = Round1.SelectedIndex;
                Round1.Items.RemoveAt(i);
            }           
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (Round2.SelectedItem !=null)
             Round2.Items.RemoveAt(Round2.SelectedIndex);           
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (Round2.SelectedIndex!=-1)
            {
                int say = Round2.Items.Count;
                Random rnd = new Random();
                int count = rnd.Next(0, say);
                Round2.SelectedIndex = count;
            }           
        }       
        private void btnsc3_Click(object sender, EventArgs e)
        {
            if (Round2.SelectedItems != null && Round2.SelectedIndex!=-1)
                Round3.Items.Add(Round2.SelectedItem);
            int i = 0;
            i = Round2.SelectedIndex;
            Round2.Items.RemoveAt(i);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (Round3.SelectedItem != null)
                Round3.Items.RemoveAt(Round3.SelectedIndex);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (Round3.SelectedIndex!=-1)
            {
                int say = Round3.Items.Count;
                Random rnd = new Random();
                int count = rnd.Next(0, say);
                Round3.SelectedIndex = count;
            }         
        }
        private void btnsc4_Click(object sender, EventArgs e)
        {
            if (List.SelectedItem != null)
                URound1.Items.Add(List.SelectedItem);           
            if (List2.SelectedItem != null)           
                URound1.Items.Add(List2.SelectedItem);           
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (URound1.SelectedItem != null)            
                URound1.Items.RemoveAt(URound1.SelectedIndex);           
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (URound1.SelectedIndex!=-1)
            {
                int say = URound1.Items.Count;
                Random rnd = new Random();
                int count = rnd.Next(0, say);
                URound1.SelectedIndex = count;
            }          
        }
        private void btnsc5_Click(object sender, EventArgs e)
        {
            if (Round1.SelectedItem != null)           
                URound2.Items.Add(Round1.SelectedItem);
            if (Round1.SelectedIndex!=-1)
            {
                int i = 0;
                i = Round1.SelectedIndex;
                Round1.Items.RemoveAt(i);
            }          
            if (URound1.SelectedItem != null)           
               URound2.Items.Add(URound1.SelectedItem);
            if (URound1.SelectedIndex!=-1)
            {
                int i1 = 0;
                i1 = URound1.SelectedIndex;
                URound1.Items.RemoveAt(i1);
            }           
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (URound2.SelectedItem != null)           
               URound2.Items.RemoveAt(URound2.SelectedIndex);            
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (URound2.SelectedIndex!=-1)
            {
                int say = URound2.Items.Count;
                Random rnd = new Random();
                int count = rnd.Next(0, say);
                URound2.SelectedIndex = count;
            }          
        }
        private void btnsc6_Click(object sender, EventArgs e)
        {
            if (Round2.SelectedItem != null)           
                URound3.Items.Add(Round2.SelectedItem);
            if (Round2.SelectedIndex!=-1)
            {
                int i = 0;
                i = Round2.SelectedIndex;
                Round2.Items.RemoveAt(i);
            }           
            if (URound2.SelectedItem != null)            
                URound3.Items.Add(URound2.SelectedItem);
            if (URound2.SelectedIndex!=-1)
            {
                int i1 = 0;
                i1 = URound2.SelectedIndex;
                URound2.Items.RemoveAt(i1);
            }           
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (URound3.SelectedItem != null)           
                URound3.Items.RemoveAt(URound3.SelectedIndex);            
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (URound3.SelectedIndex!=-1)
            {
                int say = URound3.Items.Count;
                Random rnd = new Random();
                int count = rnd.Next(0, say);
                URound3.SelectedIndex = count;
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Round3.SelectedItems != null)
                Round4.Items.Add(Round3.SelectedItem);
            int i = 0;
            i = Round3.SelectedIndex;
            Round3.Items.RemoveAt(i);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Round4.SelectedItem != null && Round4.SelectedIndex != -1)
                Round4.Items.RemoveAt(Round4.SelectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Round3.SelectedItem != null)
                URound4.Items.Add(Round3.SelectedItem);
            if (Round3.SelectedIndex != -1)
            {
                int i = 0;
                i = Round3.SelectedIndex;
                Round3.Items.RemoveAt(i);
            }
            if (URound3.SelectedItem != null)
                URound4.Items.Add(URound3.SelectedItem);
            if (URound3.SelectedIndex != -1)
            {
                int i1 = 0;
                i1 = URound3.SelectedIndex;
                URound3.Items.RemoveAt(i1);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {   
            if (URound4.SelectedItem != null)
                URound4.Items.RemoveAt(URound4.SelectedIndex);
        }
    }
}