using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru = 0, doğru = 0, yanlış = 0;

        private void buttonb_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonsonra.Enabled = true;

            label5.Text = buttonb.Text;
            if (label4.Text==label5.Text)
            {
                doğru++;
                labeldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                labelyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonsonra.Enabled = true;

            label5.Text = buttonc.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                labeldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                labelyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonsonra.Enabled = true;

            label5.Text = buttond.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                labeldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                labelyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttona_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonsonra.Enabled = true;
            label5.Text = buttona.Text;
            if (label4.Text==label5.Text)
            {
                doğru++;
                labeldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                labelyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonsonra_Click(object sender, EventArgs e)
        {

            buttona.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
            buttonsonra.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soru++;
            labelsoru.Text = soru.ToString();
            if (soru==1)
            {
                richTextBox1.Text = "Duru sakin havada çıkan kuru soğuk anlamına gelen ayaz kelimesinin kökeni hangisidir?";
                buttona.Text="Aydınlık";
                buttonb.Text = "Keskinlik";
                buttonc.Text = "Karanlık";
                buttond.Text = "Yalnızlık";
                label4.Text = "Aydınlık";
            }
            if (soru==2)
            {
                richTextBox1.Text = "Çin Seddi nerededir?";
                buttona.Text = "Çin";
                buttonb.Text = "Hindistan";
                buttonc.Text = "Güney Kore";
                buttond.Text = "Japonya";
                label4.Text = "Çin";
            }
            if (soru==3)
            {
                richTextBox1.Text = "Türkçede kelimeler en çok hangi harfle başlar?";
                buttona.Text = "K harfi";
                buttonb.Text = "M harfi";
                buttonc.Text = "R harfi";
                buttond.Text = "S harfi";
                label4.Text = "K harfi";
                buttonsonra.Text = "Sonuçlar";
            }
            if (soru==4)
            {
                buttona.Enabled = false;
                buttonb.Enabled = false;
                buttonc.Enabled = false;
                buttond.Enabled = false;
                buttonsonra.Enabled = false;
                MessageBox.Show("Doğru: "+doğru+" \n"+"Yanlış: "+yanlış);
            }
        }
    }
}
