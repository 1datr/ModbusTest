using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ModbusTest
{
    public partial class TerminalForm : Form
    {
        public TerminalForm()
        {
            InitializeComponent();
        }

        public void printmess(string str)
        {
            string newstr =  "[" + System.DateTime.Now + "] " + str;

            using (FileStream fs = new FileStream("ModbusTest.log", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(newstr);
                }
            }

            this.textBox1.Text = this.textBox1.Text + newstr + "\r\n";
            
            
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;

            this.textBox1.ScrollToCaret();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
