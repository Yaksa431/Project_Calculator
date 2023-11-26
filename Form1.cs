using System;
using System.Windows.Forms;

namespace Проект2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Numb1, Numb2, count;
        private void Num1_Click(object sender, EventArgs e)
        {
            TextBox.Text += 1;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            TextBox.Text += 2;
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            TextBox.Text += 3;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            TextBox.Text += 4;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            TextBox.Text += 5;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            TextBox.Text += 6;
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            TextBox.Text += 7;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            TextBox.Text += 8;
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            TextBox.Text += 9;
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            TextBox.Text += 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Numb1 = int.Parse(TextBox.Text);
                TextBox.Clear();
                count = 1;
                Label.Text = Numb1.ToString() + "+";
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели число!");
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            try
            {
                Numb1 = int.Parse(TextBox.Text);
                TextBox.Clear();
                count = 2;
                Label.Text = Numb1.ToString() + "-";
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели число!");
            }
        }

        private void Eql_Click(object sender, EventArgs e)
        {
            Calculate();
            Label.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Label.Text = "";
            TextBox.Text = "";
        }

        public void Calculate()
        {
            try
            {
                switch (count)
                {
                    case 1:
                        Numb2 = Numb1 + int.Parse(TextBox.Text);
                        TextBox.Text = Numb2.ToString();
                        break;
                    case 2:
                        Numb2 = Numb1 - int.Parse(TextBox.Text);
                        TextBox.Text = Numb2.ToString();
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели второе число!");
            }
        }
    }
}
