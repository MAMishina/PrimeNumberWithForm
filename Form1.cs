using System;
using System.Numerics;
using System.Security.Cryptography;

namespace PrimeNumberWithForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_button1_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            answer_label1.Text = "Является ли введенное число простым?";
            BigInteger number;
            bool tryParse = BigInteger.TryParse(input_textBox1.Text, out number);
            if (tryParse)
            {
                if (MillerRabinTest(number, 1000))
                {
                    answer_label1.Text += "\nДа!";
                }
                else
                {
                    answer_label1.Text += "\nНет!";
                }
            }
            else
            {
                answer_label1.Text += "\nВы осуществили некорректный ввод.\nПопробуйте еще раз.";
            }
            TimeSpan timeOfWork = DateTime.Now - start;
            answer_label1.Text += "\nВремя выполнения программы: " + timeOfWork.ToString();
        }

        static bool MillerRabinTest(BigInteger n, int k)
        {
            
            // если n == 2 или n == 3 - эти числа простые, возвращаем true
            if (n == 2 || n == 3)
                return true;

            // если n < 2 или n четное - возвращаем false
            if (n < 2 || n % 2 == 0)
                return false;

            // представим n − 1 в виде (2^s)·t, где t нечётно, это можно сделать последовательным делением n - 1 на 2
            BigInteger t = n - 1;

            int s = 0;

            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }

            for (int i = 0; i < k; i++)
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                byte[] _a = new byte[n.ToByteArray().LongLength];

                BigInteger a;

                do
                {
                    rng.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= n - 2);
                BigInteger x = BigInteger.ModPow(a, t, n);
                if (x == 1 || x == n - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answer_label1.Text = "Является ли введенное число простым?\n";
            BigInteger number;
            bool tryParse = BigInteger.TryParse(input_textBox1.Text, out number);
            int countDel = 1;
            if (tryParse)
            {
                DateTime start = DateTime.Now;
                for (BigInteger i = 1; i <= (number/2 + 1); i++)
                {
                    if (number % i == 0)
                    {
                        countDel++;
                        answer_label1.Text += " "+ i;
                        if (countDel > 2)
                        {
                            answer_label1.Text += "\nНет!";
                            break;
                        }
                    }
                    
                }
                
                TimeSpan finish = DateTime.Now - start;
                answer_label1.Text+= "\nВремя выполнения программы: " + finish.ToString();
            }
        }

        private void input_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

    }
}