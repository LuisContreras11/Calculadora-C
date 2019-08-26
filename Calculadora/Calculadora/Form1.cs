using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
            double segundo;
            string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "7";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "0";

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "6";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "9";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ".";
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void BtnPorc_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }
    }
}
