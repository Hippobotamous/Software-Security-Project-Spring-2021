using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensor_Application
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private string deviceName;

        public string getDeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT";
            string sql2 = "CHOOSE";
            string sql3 = "WHERE";
            string sql4 = "COUNT";
            string sql5 = "=";
            string sql6 = "*";
            string sql7 = "WHERE";
            string sql8 = "AND";
            string passwordVT = "vt";
            string usernameVT = "vt";
            string passwordPSX = "psx";
            string usernamePSX = "psx";

            if (textBox2.Text == sql1 || textBox2.Text == sql2 || textBox2.Text == sql3 || textBox2.Text == sql4
                || textBox2.Text == sql5 || textBox2.Text == sql6 || textBox2.Text == sql7 || textBox2.Text == sql8)
                MessageBox.Show("Invalid Credentials"); //Talk about how error messages don't give anything away

            if (textBox2.Text != usernameVT && textBox2.Text != usernamePSX)
                MessageBox.Show("Invalid Credentials");

            if (textBox1.Text != passwordVT && textBox1.Text != passwordPSX)
                MessageBox.Show("Invalid Credentials");

            if (textBox2.Text == usernameVT && textBox1.Text == passwordVT
                || textBox2.Text == usernamePSX && textBox1.Text == passwordPSX)
            {
                MessageBox.Show("Correct Credentials");
                getDeviceName = textBox2.Text;
                MessageBox.Show(getDeviceName);
                MessageBox.Show(textBox2.Text);
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                
                
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
