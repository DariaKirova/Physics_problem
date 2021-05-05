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
            Text = "Programm_1";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool mistake = false;
            double t1 = -1, v0 = -1, v1 = -1, v2 = -1;
            
            while (mistake != true)
            {
                t1 = Convert.ToDouble(T1.Text);
                if  (t1 < 0){
                    MessageBox.Show("Вы ввели отрицательное значение. Пожалуйста введите положительное число!");
                    mistake = false;
                    T1.Text = "";
                }
                else if (t1 == 0){
                    MessageBox.Show("t1 не может равняться 0, так как в одном из уравнений оно - делимое. Пожалуйста введите положительное число!");
                    mistake = false;
                    T1.Text = "";
                }
                else if (t1 >= 10000)
                {
                    MessageBox.Show("Вы не можете вводить числа больше 10000. Пожалуйста введите меньшее число!");
                    mistake = false;
                    T1.Text = "";
                }
                else if ((t1>0) && (t1<10000)){
                    t1 = Convert.ToDouble(T1.Text);
                    mistake = true;
                    continue;
                }           
                return;               
            }
            mistake = false;

            while (mistake != true)
            {
                v0 = Convert.ToDouble(V0.Text);
                if (v0 < 0){
                    MessageBox.Show("Вы ввели отрицательное значение. Пожалуйста введите положительное число!");
                    mistake = false;
                    V0.Text = "";
                }
                else if (v0 >= 10000)
                {
                    MessageBox.Show("Вы не можете вводить числа больше 10000. Пожалуйста введите меньшее число!");
                    mistake = false;
                    V0.Text = "";
                }
                else {
                    v0 = Convert.ToDouble(V0.Text);
                    mistake = true;
                    continue;
                }
                return;
            }
            mistake = false;

            while (mistake != true)
            {
                v1 = Convert.ToDouble(V1.Text);
                if (v1 < 0){
                    MessageBox.Show("Вы ввели отрицательное значение. Пожалуйста введите положительное число!");
                    mistake = false;
                    V1.Text = "";
                }
                else if (v1 >= 10000)
                {
                    MessageBox.Show("Вы не можете вводить числа больше 10000. Пожалуйста введите меньшее число!");
                    mistake = false;
                    V1.Text = "";
                }
                else {
                    v1 = Convert.ToDouble(V1.Text);
                    mistake = true;
                    continue;
                }
                return;
            }
            mistake = false;

            while (mistake != true)
            {
                v2 = Convert.ToDouble(V2.Text);
                if (v2 < 0){
                    MessageBox.Show("Вы ввели отрицательное значение. Пожалуйста введите положительное число!");
                    mistake = false;
                    V2.Text = "";
                }
                else if (v2 >= 10000)
                {
                    MessageBox.Show("Вы не можете вводить числа больше 10000. Пожалуйста введите меньшее число!");
                    mistake = false;
                    V2.Text = "";
                }
                else if (v2>= 0){
                    v2 = Convert.ToDouble(V2.Text);
                    mistake = true;
                    continue;
                }
                return;
            }
            mistake = false;

            double a = v1 / t1;
            double t2 = v2/ a;
            A.Text = String.Format("{0:f2}", v1 / t1);
            T2.Text = String.Format("{0:f2}", t2);
            S2.Text = String.Format("{0:f2}", a *t2*t2/2);
        }
        private void Form1_Load(object sender, EventArgs e){   
        }
        private void label1_Click(object sender, EventArgs e){
        }
        private void label6_Click(object sender, EventArgs e){
        }
        private void label8_Click(object sender, EventArgs e){
        }
        private void label16_Click(object sender, EventArgs e){
        }
        private void A_TextChanged(object sender, EventArgs e){
        }
        private void T1_TextChanged(object sender, EventArgs e){          
        }
    }
}
