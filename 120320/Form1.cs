using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _120320
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!");
            ButtonTimer.Enabled = !ButtonTimer.Enabled;

        }

        private void OnButtonTimerTick(object sender, EventArgs e)
        {
            FirstButton.Left += 10;
            if (FirstButton.Left > Width) FirstButton.Left = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton(object sender, EventArgs e)
        {
            double x, y;
            if (!double.TryParse(Operand1.Text, out x))
            {
                MessageBox.Show("Ошибка ввода А");
                return;
            }
            if (!double.TryParse(Operand2.Text, out y))
            {
                MessageBox.Show("Ошибка ввода B");
                return;
            }
            var op = Operator.Text;
            switch (op)
            {
                case "Add":
                case "+":
                    ResultValue.Text = (x + y).ToString();
                    break;
                case "-":
                    ResultValue.Text = (x - y).ToString();
                    break;
                default:
                    MessageBox.Show("Неизвестный оператор" + op);
                    break;
            }
        }
    }
}
