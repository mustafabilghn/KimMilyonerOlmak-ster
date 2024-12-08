using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 1, dogru = 0, yanlıs = 0;

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label7.Text = btnA.Text;

            if (label1.Text == label7.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label7.Text = btnB.Text;

            if (label1.Text == label7.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible=true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible=true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label7.Text = btnC.Text;

            if (label1.Text == label7.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label7.Text = btnD.Text;

            if (label1.Text == label7.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnsonraki.Enabled = false;

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label1.Text = "1923";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblsoru.Text = soruno.ToString();

            if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi asal sayıdır?";
                btnA.Text = "1";
                btnB.Text = "2";
                btnC.Text = "4";
                btnD.Text = "6";
                label1.Text = "2";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri Güntekin";
                label1.Text = "Sait Faik Abasıyanık";
                btnsonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                lblsoru.Text = 3.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "\n" + "Yanlış:" + yanlıs);
            }
        }
    }
}
