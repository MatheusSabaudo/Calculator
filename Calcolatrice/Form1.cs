using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys tasto)
        {
            if (tasto >= Keys.D0 && tasto <= Keys.D9 || tasto ==  Keys.Oemcomma || tasto == Keys.Back) 
            {
                return false;

            }else   
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double risultato = n1 + n2;
            lbl_risultato.Text = risultato.ToString(); 
        }

        private void btn_meno_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double risultato = n1 - n2;
            lbl_risultato.Text = risultato.ToString();
        }

        private void btn_per_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double risultato = n1 * n2;
            lbl_risultato.Text = risultato.ToString();
        }

        private void btn_elev_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double risultato = Math.Pow(n1, n2);
            lbl_risultato.Text = risultato.ToString();
        }

        private void btn_modulo_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double risultato = n1 % n2;
            lbl_risultato.Text = risultato.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double risultato = n1 / n2;
            lbl_risultato.Text = risultato.ToString();
        }

        private void btn_radice_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_num1.Text);
            double n2 = Convert.ToDouble(txt_num2.Text);

            double risultato = Math.Sqrt(n1);
            lbl_risultato.Text = risultato.ToString();
        }

        private void btn_estrazione_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txt_num1.Text);
            int n2 = Convert.ToInt32(txt_num2.Text);

            Random rnd = new Random();
            int num = rnd.Next(n1, n2);

            lbl_risultato.Text = num.ToString();
        }
    }
}
