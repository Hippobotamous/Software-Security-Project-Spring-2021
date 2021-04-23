using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sensor_Application
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string ipAddress;
        public string getIpAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipAddress1 = "192.128.0.";
            int x = 0;
            while (x <= 255)
            {
                string newIP = ipAddress1 + x;
                listBox1.Items.Add(newIP);
                x += 1;
            }

            string ipAddress2 = "192.128.1.";
            int y = 0;
            while (y <= 255)
            {
                string newIP = ipAddress2 + y;
                listBox1.Items.Add(newIP);
                y += 1;
            }

            string ipAddress3 = "192.128.2.";
            int z = 0;
            while (z <= 255)
            {
                string newIP = ipAddress3 + z;
                listBox1.Items.Add(newIP);
                z += 1;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getIpAddress = textBox1.Text;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
