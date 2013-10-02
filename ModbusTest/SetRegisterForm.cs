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
    public partial class SetRegisterForm : Form
    {
        public SetRegisterForm()
        {
            InitializeComponent();
        }

        private void SetRegisterForm_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }

        public Form1 OwnerForm;
 
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedItem=="Int")
                    OwnerForm.setRegUshortValue(Convert.ToUInt16(tbBeginAddr.Text),Convert.ToUInt16(tbValue.Text));
            else if(this.comboBox1.SelectedItem=="Float")
                OwnerForm.setRegFloatValue(Convert.ToUInt16(tbBeginAddr.Text), Convert.ToSingle(tbValue.Text));           
        }
    }
}
