﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
                double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double radiansA = a * (Math.PI / 180);
            double resultA = 1 / Math.Tan(radiansA);
            
            double radiansB = b * (Math.PI / 180);
            double resultB = 1 / Math.Tan(radiansB);
            
            textBox3.Text = Convert.ToString(resultA);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(resultB);
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
                double a = Convert.ToDouble(textBox1.Text); 
            double b = Convert.ToDouble(textBox2.Text);
            
            double radiansA = a * (Math.PI / 180);
            double resultA = Math.Tan(radiansA);
            
            double radiansB = b * (Math.PI / 180);
            double resultB = Math.Tan(radiansB);
            
            textBox3.Text = Convert.ToString(resultA);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(resultB);
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double radiansA = a * (Math.PI / 180);
            double resultA = Math.Cos(radiansA);
            
            double radiansB = b * (Math.PI / 180);
            double resultB = Math.Cos(radiansB);
            
            textBox3.Text = Convert.ToString(resultA);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(resultB);
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double radiansA = a * (Math.PI / 180);
            double resultA = Math.Sin(radiansA);
            
            double radiansB = b * (Math.PI / 180);
            double resultB = Math.Sin(radiansB);
            
            textBox3.Text = Convert.ToString(resultA);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(resultB);
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double sum = a + b;
                textBox3.Text = Convert.ToString(sum);

            }
            catch 
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
                double a = Convert.ToDouble(textBox1.Text); 
            double b = Convert.ToDouble(textBox2.Text);
            double sum = a - b;
            textBox3.Text = Convert.ToString(sum);
            }
            catch
            {
                MessageBox.Show("ВНекорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
                    double a = Convert.ToDouble(textBox1.Text); 
            double b = Convert.ToDouble(textBox2.Text);
            double sum = a * b;
            textBox3.Text = Convert.ToString(sum);
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           try //---------------------------------------------------------------------------------------||||||||||||
           {
                        double a = Convert.ToDouble(textBox1.Text); 
            double b = Convert.ToDouble(textBox2.Text);
            double sum = a / b;
            textBox3.Text = Convert.ToString(sum);
           }
            catch
           {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            textBox3.TextAlign = HorizontalAlignment.Center;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
            double a = Convert.ToDouble(textBox1.Text); 
            double b = Convert.ToDouble(textBox2.Text);
            double sum = Math.Pow(a,b);
            textBox3.Text = Convert.ToString(sum);
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                double a_sum = Math.Log(a , 2.718281828459045);
                double b_sum = Math.Log(b , 2.718281828459045);

                textBox3.Text = Convert.ToString(a_sum);
                textBox3.Text += Convert.ToString(" | ");
                textBox3.Text += Convert.ToString(b_sum);


            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.TextAlign = HorizontalAlignment.Center;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try //---------------------------------------------------------------------------------------||||||||||||
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                double a_sum = Math.Log10(a);
                double b_sum = Math.Log10(b);

                textBox3.Text = Convert.ToString(a_sum);
                textBox3.Text += Convert.ToString(" | ");
                textBox3.Text += Convert.ToString(b_sum);

            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            }
                textBox3.TextAlign = HorizontalAlignment.Center; // Выравнивает весь текст по центру. ВЕЗДЕ

        }

        private void button15_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double radiansA = a * (Math.PI / 180);
            double resultA = Math.Cos(radiansA);

            double radiansB = b * (Math.PI / 180);
            double resultB = Math.Cos(radiansB);

            double resultA_A = 1 - resultA;
            double resultB_B = 1 - resultB;

            textBox3.Text = Convert.ToString(resultA_A);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(resultB_B);


        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double radianssA = a * (Math.PI / 180);
            double resultsA = Math.Sin(radianssA);

            double radianssB = b * (Math.PI / 180);
            double resultsB = Math.Sin(radianssB);

            double resultA_AS = 1 - resultsA;
            double resultB_BS = 1 - resultsB;

            textBox3.Text = Convert.ToString(resultA_AS);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(resultB_BS);
            textBox3.TextAlign = HorizontalAlignment.Center; // Выравнивает весь текст по центру. ВЕЗДЕ

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form frm2 = new Form2(); //где Form2 - название вашей формы
            frm2.Show();
            frm2.Select();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString("  ");
            textBox2.Text = Convert.ToString("  ");
            textBox3.Text = Convert.ToString("  ");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);

            double b = Convert.ToDouble(textBox2.Text);

            double sum_a = 1;
            double sum_b = 1;

            for (int i = 2; i <= a; i++ ) 
            {
                sum_a = sum_a* i;
                
            }

            for (int i = 2; i <= b; i++)
            {
                sum_b = sum_b * i;

            }

            textBox3.Text = Convert.ToString(sum_a);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(sum_b);
            textBox3.TextAlign = HorizontalAlignment.Left;
            

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);

            double b = Convert.ToDouble(textBox2.Text);

            double sum_A = Math.Sqrt(a);
            double sum_B = Math.Sqrt(b);


            textBox3.Text = Convert.ToString(sum_A);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(sum_B);
            textBox3.TextAlign = HorizontalAlignment.Center; // Выравнивает весь текст по центру. ВЕЗДЕ

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);

            double b = Convert.ToDouble(textBox2.Text);

            double sum_AS = Math.Pow(Math.Sqrt(a), 1.0 / 3.0);
            double sum_BS = Math.Pow(Math.Sqrt(b), 1.0 / 3.0);

            textBox3.Text = Convert.ToString(sum_AS);
            textBox3.Text += Convert.ToString(" | ");
            textBox3.Text += Convert.ToString(sum_BS);
            textBox3.TextAlign = HorizontalAlignment.Center; // Выравнивает весь текст по центру. ВЕЗДЕ

        }
    }

}
