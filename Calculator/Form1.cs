using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double isi = 0;
        String operasi = "";
        bool operasi_tekan = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((Hasil.Text == "0")||(operasi_tekan))
                Hasil.Clear();

            operasi_tekan = false;
            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Hasil.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operasi = b.Text;
            isi = Double.Parse(Hasil.Text);
            operasi_tekan = true;
            equation.Text = isi + " " + operasi;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operasi)
            {
                case "+":
                    Hasil.Text = (isi + Double.Parse(Hasil.Text)).ToString();
                    break;
                case "-":
                    Hasil.Text = (isi - Double.Parse(Hasil.Text)).ToString();
                    break;
                case "x":
                    Hasil.Text = (isi * Double.Parse(Hasil.Text)).ToString();
                    break;
                case "/":
                    Hasil.Text = (isi / Double.Parse(Hasil.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Hasil.Text = "0";
            isi = 0;
        }

        private void Hasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hasil.Text = Hasil.Text + ",";
        }
    }
}
