using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 矩阵旋转
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double theta;
            double X_in, Y_in, Z_in;//输入坐标
            double X_out, Y_out, Z_out;//输出坐标
            double A, B, C, D, E, F, G, H, I;//旋转矩阵元素
            
            theta = Convert.ToDouble(textBox1.Text.ToString());//旋转角值（弧度）
            X_in = Convert.ToDouble(textBox2.Text.ToString());
            Y_in = Convert.ToDouble(textBox3.Text.ToString());
            Z_in = Convert.ToDouble(textBox4.Text.ToString());//输入坐标

            A = Math.Cos(theta);
            B = Math.Sin(theta);
            D = -B;
            E = A;
            C = F = G = H = I = 0;

            double[,] R = { 
                          { A, B, C }, 
                          { D, E, F }, 
                          { G, H, I } 
                          };//旋转矩阵
            double[] IN = { X_in, Y_in, Z_in };//输入坐标数组

            //----------------------------调试用--------------------------------
            //double[,] R = { 
            //              { 1, 2, 3 }, 
            //              { 4, 5, 6 }, 
            //              { 7, 8, 9 } 
            //              };//旋转矩阵
            //double[] IN = { 1, 2, 3 };//输入坐标数组
            //------------------------------------------------------------------

            double[] OUT = { 1, 1, 1 };//输出坐标数组
            int i, j;
            double sum;
            for (i = 0; i < 3; i++)
            {
                sum = 0;
                for (j = 0; j < 3;j++ )
                {
                    sum += R[i, j] * IN[j];
                }
                OUT[i] = sum;
            }
            X_out = OUT[0];
            Y_out = OUT[1];
            Z_out = OUT[2];

            textBox5.Text = Convert.ToString(X_out);
            textBox6.Text = Convert.ToString(Y_out);
            textBox7.Text = Convert.ToString(Z_out);//输出结果
        }
    }
}
