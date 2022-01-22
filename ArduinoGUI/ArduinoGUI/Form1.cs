using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoGUI
{
    public partial class Form1 : Form
    {
        private string red,green,blue;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(serialPort2.IsOpen)
            {
                conn.BringToFront();
            }
            else
            {
                notcon.BringToFront();
                serialPort2.PortName = comboBox1.Text;
                serialPort2.Open();
                conn.BringToFront();
            }
        }
        public Form1()
        {            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(serialPort2.IsOpen)
            {
                serialPort2.Write("R255");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("r");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("G255");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(serialPort2.IsOpen)
            {
                serialPort2.Write("g");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("B255");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("b");
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                blue = "B" + trackBar3.Value;
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                red = "R" + trackBar1.Value;
            }
                
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                green = "G" + trackBar2.Value;
            }
                
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                if (string.IsNullOrEmpty(red))
                {
                    red = "R0";
                }
                serialPort2.Write(red);
            }
                
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                if (string.IsNullOrEmpty(green))
                {
                    green = "G0";
                }
                serialPort2.Write(green);
            }
                
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                if (string.IsNullOrEmpty(blue))
                {
                    blue = "B0";
                }
                serialPort2.Write(blue);
            }
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             string[] ports = SerialPort.GetPortNames();
             comboBox1.Items.AddRange(ports);                
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
