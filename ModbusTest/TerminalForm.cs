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
        // вывод сообщения в терминал
        public string ShowBuff(string str)
        {
            this.textBox1.Text = str;            
            
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;

            this.textBox1.ScrollToCaret();

            return textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AnimTimer(bool close=false)
        {
            string buf = "|/-\\|/-\\";
            if (close)
            { 
            
            }

        }
    }
}
