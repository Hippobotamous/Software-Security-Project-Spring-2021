using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sensor_Application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string ipAddress)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            label15.Text = f1.getDeviceName;
        }

        private void label1_Click(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            if (f3.ShowDialog() == DialogResult.OK)
            {
                label5.Text = f3.getIpAddress;
                
            }
            int chooseCity = city();
            if (chooseCity <= 50)
                label6.Text = "Spokane, WA";
            else if (chooseCity > 50)
                label6.Text = "Great Falls, MT";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private readonly Random randomFlowLevel = new Random();
        private readonly Random randomViscosity = new Random();
        private readonly Random randomTemp = new Random();
        private readonly Random randomCity = new Random();

        public int flowLevel(int min, int max)
        {
            return randomFlowLevel.Next(min, max);
        }

        public int viscosity(int min, int max)
        {
            return randomViscosity.Next(min, max);
        }

        public int temperature(int min, int max)
        {
            return randomTemp.Next(min, max);
        }

        public int city()
        {
            return randomCity.Next(1, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                label7.Text = "Flow Level: "+ flowLevel(1, 100).ToString();
                label8.Text = "Viscosity: "+(viscosity(400, 600).ToString())+"cps";
                label10.Text = (temperature(35, 45).ToString())+"C";
                label13.Text = (temperature(55, 120).ToString())+"C";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }
    }
}
