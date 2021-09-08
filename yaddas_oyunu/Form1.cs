using System;
using System.Windows.Forms;

namespace yaddas_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Visible = false;
            button2.Enabled = false;
        }
        public int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a = a + 1;
            Random say = new Random();
            int nom = say.Next(1,10);
            label2.Text = label2.Text + nom;
            label1.Text = nom.ToString();
            if (a==7)
            {
                //label1.Text = "gorduyunuz reqemleri girin";
                timer1.Stop();
                textBox1.Enabled = true;
                button2.Enabled = true;
                label3.Visible = true;
                //label1.Visible = false;
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label2.Text)
            {

                MessageBox.Show("Butun Reqemleri Bildiniz ! ", "DIQQET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Duzgun deyil, Yaddasinizi Tezeleyin !!! Duzgun Cavab   " + label2.Text, "DIQQET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            /*
               a = 0;
               label2.Text = "";
               button1.Visible = true;
               button2.Visible = true;
               button2.Enabled = false;
            */
        }


        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
