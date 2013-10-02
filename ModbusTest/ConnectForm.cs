using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModbusTest
{
    public partial class ConnectForm : Form
    {
        private drvCon con;

        public ConnectForm()
        {
            InitializeComponent();
        }

        public ConnectForm(drvCon con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 OwnerForm = (Form1)Owner;
            if (con.Connect(textBox1.Text))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                OwnerForm.PrintTerminal("Установлено соединение с " + textBox1.Text);
            }
            else
            {
                label3.Text = "Не удается соединиться с " + textBox1.Text;
                OwnerForm.PrintTerminal("Не удается соединиться с " + textBox1.Text);
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
