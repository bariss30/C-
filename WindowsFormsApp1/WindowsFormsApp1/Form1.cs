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

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int secilenSayi = rnd.Next(0, 3);
            button1.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;


            switch (secilenSayi)
            {
                case 0:
                    button1.BackColor = Color.Blue;
                    button2.BackColor=Color.Blue;
                    label1.Text = "beraber";
                   
                  
                    break;
                case 1:
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Green;
                    label1.Text = "Kaybettin";
                    break;
                case 2:
                    button2.BackColor = Color.Green;
                    button5.BackColor = Color.Red;
                    label1.Text = "Kazzandın";
                    break;
                default:
                    Console.WriteLine("Geçersiz sayı.");
                    break;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int secilenSayi = rnd.Next(0, 3);
            button1.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;


            switch (secilenSayi)
            {
                case 0:
                    button4.BackColor = Color.Green;
                    button1.BackColor = Color.Red;
                    label1.Text = "Kazandın";


                    break;
                case 1:
                    button4.BackColor = Color.Blue;
                    button3.BackColor = Color.Blue;
                    label1.Text = "Berabere";
                    break;
                case 2:
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Green;
                    label1.Text = "Kaybettin";
                    break;
                default:
                    Console.WriteLine("Geçersiz sayı.");
                    break;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int secilenSayi = rnd.Next(0, 3);
            button1.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;


            switch (secilenSayi)
            {
                case 0:
                    button6.BackColor = Color.Red;
                    button1.BackColor = Color.Green;
                    label1.Text = "Kaybettin";


                    break;
                case 1:
                    button6.BackColor = Color.Green;
                    button3.BackColor = Color.Red;
                    label1.Text = "Kazandın";
                    break;
                case 2:
                    button6.BackColor = Color.Blue;
                    button5.BackColor = Color.Blue;
                    label1.Text = "Berabere";
                    break;
                default:
                    Console.WriteLine("Geçersiz sayı.");
                    break;
            }

        }
    
    
    }
}
