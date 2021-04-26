using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

        //public Form2(string ipAddress)
        //{
        //    InitializeComponent();
        //}


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private readonly Random randomFlowLevel = new Random();
        private readonly Random randomViscosity = new Random();
        private readonly Random randomTemp = new Random();
        private readonly Random randomCity = new Random();
        private readonly Random randomSpeed = new Random();

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

        public int speed(int min, int max)
        {
            return randomSpeed.Next(min, max);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                int flowLevelInPipe = flowLevel(1, 100);
                int viscosityOfOil = viscosity(300, 700);
                int temperatureInside = temperature(25, 55);
                int temperatureOutside = temperature(0, 120);
                int flowSpeed = speed(2, 15);

                label7.Text = "Flow Level: "+ flowLevelInPipe.ToString()+"%";

                if (flowLevelInPipe < 20)
                    label17.Text = "Warning: Flow level is too low.";
                else
                    label17.Text = "";

                label8.Text = "Viscosity: "+(viscosityOfOil.ToString())+"cps";
                if (viscosityOfOil < 300)
                    label18.Text = "Warning: Low viscosity";
                else if (viscosityOfOil > 600)
                    label18.Text = "Warning: High viscosity";
                else
                    label18.Text = "";

                label10.Text = temperatureInside.ToString()+"C";
                if (temperatureInside < 35)
                    label19.Text = "Warning: Inside temperature too low.";
                else if (temperatureInside > 45)
                    label19.Text = "Warning: Inside temperature too high.";
                else
                    label19.Text = "";

                label13.Text = temperatureOutside.ToString() + "C";
                if (temperatureOutside < 30)
                    label20.Text = "Warning: Outside temperature too low";
                else if (temperatureOutside > 100)
                    label20.Text = "Warning: Outside temperature too high";
                else
                    label20.Text = "";

                //label 21 and 22

                label22.Text = flowSpeed.ToString();
                if (flowSpeed < 3)
                    label21.Text = "Warning: Flow speed too low";
                else if (flowSpeed > 10)
                    label21.Text = "Warning: Flow speed too high";
                else
                    label21.Text = "";

                string dataFile = @"C:\Users\lande\source\repos\Hippobotamous\Sensor-Application\Sensor Application\data.csv";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@dataFile, true))
                {
                    file.WriteLine("Flow level" + "," + "Temp in" + "," + "Temp out" + "," + "Viscosity");
                    file.WriteLine(flowLevelInPipe.ToString() + "," + temperatureInside.ToString()
                        + "," + temperatureOutside.ToString() + "," + viscosityOfOil.ToString()
                        + "," + flowSpeed.ToString());
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Button Click Works");
            string databaseFile = @"C:\Users\lande\source\repos\Hippobotamous\Sensor-Application\Sensor Application\database.csv";
            string delimiter = ", ";
            string dataNames = "Exxon Sensor" + delimiter + "Date" + delimiter + "Time" + delimiter +
                "Coordinates" + delimiter + "Flow level" + delimiter + "Flow speed" + delimiter +
                "Temperature" + delimiter + "Temperature" + Environment.NewLine;
            string actualData = flowLevel(1, 100).ToString() + Environment.NewLine;

            File.WriteAllText(databaseFile, dataNames);
            File.WriteAllText(databaseFile, actualData);
            for (int i = 0; i <= 1000; i++)
            {
                File.WriteAllText(databaseFile, actualData);
            }
        }

    }
}
