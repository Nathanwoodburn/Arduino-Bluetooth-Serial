using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace Arduino_Bluetooth_Serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort serialPort = new SerialPort();
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Connecting. . .";
            Thread.Sleep(100);
            try
            {
serialPort.PortName = textBox1.Text; // Set in Windows
            serialPort.Open();
                label1.Text = "Connected";
            }
            catch (Exception)
            {
                label1.Text = "Connection Failed";

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            serialPort.BaudRate = 9600;
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    if (textBox2.Text != "")
                    {
                        serialPort.Write(textBox2.Text);
                        richTextBox1.Text = richTextBox1.Text + "\nWrote >  " + textBox2.Text;
                        textBox2.Text = "";
                    }
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "\nSerial port not connected!";
                    textBox2.Text = "";
                }
                                
            }
            catch (Exception)
            {
                richTextBox1.Text = richTextBox1.Text + "\nError writting >  " + textBox2.Text;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            
            try
            {
                if (serialPort.IsOpen)
                {
                    if (serialPort.BytesToRead > 0)
                    {
                        richTextBox1.Text = richTextBox1.Text + "\n" + Convert.ToChar(serialPort.ReadByte());
                        Thread.Sleep(10);
                        while (serialPort.BytesToRead > 0)
                        {
                            richTextBox1.Text = richTextBox1.Text + Convert.ToChar(serialPort.ReadByte());
                            Thread.Sleep(10);
                        }
                    }
                }
            }
            catch (Exception)
            {


            }
            timer1.Start();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            label1.Text = "Disconnected";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        #region Buttons
        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "P";
            button2.PerformClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "O";
            button2.PerformClick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Q";
            button2.PerformClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "W";
            button2.PerformClick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "E";
            button2.PerformClick();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "R";
            button2.PerformClick();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "T";
            button2.PerformClick();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "S";
            button2.PerformClick();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "8";
            button2.PerformClick();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "2";
            button2.PerformClick();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "4";
            button2.PerformClick();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "6";
            button2.PerformClick();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "I";
            button2.PerformClick();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "L";
            button2.PerformClick();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "A";
            button2.PerformClick();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = "X";
            button2.PerformClick();
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "2";
            button2.PerformClick();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "?";
            button2.PerformClick();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "7";
            button2.PerformClick();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "9";
            button2.PerformClick();
        }
        private void button18_Click_2(object sender, EventArgs e)
        {
            textBox2.Text = "5";
            button2.PerformClick();
        }
        private void button20_Click_2(object sender, EventArgs e)
        {
            textBox2.Text = "I";
            button2.PerformClick();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            button2.PerformClick();
        }
        #endregion
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length <= 1)
            {
                textBox2.ForeColor = Color.Black;
            }
            else
            {
                textBox2.ForeColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("COM"))
                textBox1.ForeColor = Color.Black;
            else
                textBox1.ForeColor = Color.Red;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        
    }
}