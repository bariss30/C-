using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Ping p = new Ping();
        private int sayac;
        private string durum = "";
        private string adress = "";
        private string zaman = "";
        private string sonuc = "";
        private long pingAdet = 10;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.CheckState == CheckState.Checked)
            {
                pingAdet = 9999999999;
                textBox1.Text = "9999999999";
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Text = "10";
                pingAdet = Convert.ToInt32(textBox1.Text);
                textBox1.Enabled = true;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(textBox4.Text + " Adresine Ping işlemi Başlıyor... - " + DateTime.Now + Environment.NewLine);
            listBox1.Items.Add("--------------" + Environment.NewLine);
            sayac = 0;
            timer1.Interval = Convert.ToInt32(textBox2.Text);
            pingAdet = Convert.ToInt64(textBox1.Text);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac >= pingAdet)
            {
                listBox1.Items.Add("--------------" + Environment.NewLine);
                listBox1.Items.Add(sonuc + Environment.NewLine);
                listBox1.Items.Add("--------------" + Environment.NewLine);
                timer1.Stop();
                timer1.Enabled = false;
            }
            else
            {
                try
                {
                    PingReply reply = p.Send(textBox4.Text);
                    durum = reply.Status.ToString();
                    adress = reply.Address.ToString();
                    zaman = reply.RoundtripTime.ToString();
                    listBox1.Items.Add(string.Format("Sonuç : {0} {1} -> {2} ms.", durum, adress, zaman + Environment.NewLine));
                    sonuc = "Ping başarı ile tamamlandı";
                }
                catch (PingException)
                {
                    listBox1.Items.Add("Bilinen böyle bir ana bilgisayar yok" + Environment.NewLine);
                    sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
                }
                catch (NullReferenceException)
                {
                    listBox1.Items.Add("Ping Atılamadı. Adres yanlış olabilir." + Environment.NewLine);
                    sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
