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
    public partial class Form1 : Form
    {
        drvCon con;

        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void соединитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con = new drvCon();
            ConnectForm CF = new ConnectForm(con);
            CF.Owner = this;
            if (CF.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                this.TabControl.Visible = true;
            }
        }
        private TerminalForm terminalform;
        private void Form1_Load(object sender, EventArgs e)
        {
            terminalform = new TerminalForm();
        }

        public void PrintTerminal(String str)
        {
            if (terminalform == null) terminalform = new TerminalForm();
            terminalform.printmess(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WatchDINTValues();
        }


        private void WatchDINTValues()
        {
            if (!groupDINTTimer.Enabled) groupDINTTimer.Enabled = true;
            dataGridView1.Rows.Clear();
            for (ushort regaddr = ushort.Parse(textBox1.Text); regaddr <= ushort.Parse(textBox2.Text); regaddr += 2)
            {
                ushort regval = con.Reg(regaddr);
                dataGridView1.Rows.Add(regaddr.ToString(), regval.ToString());
                PrintTerminal(String.Format("%MW{0} = {1}", regaddr.ToString(), regval.ToString()));
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(con!=null)
                con.Disconnect();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WatchRealValues();
        }

        private float _2words2float(ushort[] value)
        {
            Byte[] q = new Byte[4];
            
            q[0] = BitConverter.GetBytes(value[0])[0];
            q[1] = BitConverter.GetBytes(value[0])[1];
            q[2] = BitConverter.GetBytes(value[1])[0];
            q[3] = BitConverter.GetBytes(value[1])[1];
           
            /*
            q[2] = BitConverter.GetBytes(value[0])[0];
            q[3] = BitConverter.GetBytes(value[0])[1];
            q[0] = BitConverter.GetBytes(value[1])[0];
            q[1] = BitConverter.GetBytes(value[1])[1];*/
            float res = BitConverter.ToSingle(q, 0);
            return res;

        }

        // Просмотр в формате чисел с плавающей запятой
        private void WatchRealValues()
        {
            groupRealTimer.Enabled = true;
            dataGridView2.Rows.Clear();
            for (ushort regaddr = ushort.Parse(this.tbRealAddr1.Text); regaddr <= ushort.Parse(this.tbRealAddr2.Text); regaddr+=4)
            {
                ushort[] temp = new ushort[2];
                temp[1] = con.Reg(regaddr);
                temp[0] = con.Reg((ushort)(regaddr+2));
                float val = _2words2float(temp);
                string Format = tbFormat.Text;
                string strval;
                try
                {
                    strval = val.ToString(Format);
                }
                catch(Exception e)
                {
                    strval = val.ToString("F6");
                }
                PrintTerminal(String.Format("%MW{0} = {1}", regaddr.ToString(),strval));
                dataGridView2.Rows.Add(regaddr.ToString(), strval);
            }
        }

        private void chbDINTTimer_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt16(DINTTimerStep.Text);
            timer1.Enabled = chbDINTTimer.Checked;
            if (timer1.Enabled)
            {
                PrintTerminal(String.Format("DINT Timer begin work with interval {0}", timer1.Interval));
            }
            else
            {
                PrintTerminal("DINT Timer stop working");
            }
        }
        // При ошибке
        public void OnError(string ErrStr)
        {
            MessageBox.Show("Ошибка " + ErrStr);
            PrintTerminal("Ошибка " + ErrStr);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            WatchDINTValues();
        }

        private void DINTTimerStep_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Interval = Convert.ToInt16(DINTTimerStep.Text);
                PrintTerminal(String.Format("DINT Timer begin work with interval {0}", timer1.Interval));
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            WatchRealValues();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Interval = Convert.ToInt16(DINTTimerStep.Text);
            timer2.Enabled = chbRealTimer.Checked;
            if (timer1.Enabled)
            {
                PrintTerminal(String.Format("REAL Timer begin work with interval {0}", timer2.Interval));
            }
            else
            {
                PrintTerminal("REAL Timer stop working");
            }
        }

        private void tbRealTimerStep_TextChanged(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                timer2.Interval = Convert.ToInt16(DINTTimerStep.Text);
                PrintTerminal(String.Format("REAL Timer begin work with interval {0}", timer2.Interval));
            }
        }

        private void tbRealAddr1_TextChanged(object sender, EventArgs e)
        {
            tbRealAddr2.Text = tbRealAddr1.Text;
        }

        private void терминалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (terminalform == null) terminalform = new TerminalForm();
            terminalform.Show();
        }

        public void setRegUshortValue(ushort addr, ushort value)
        {           

                con.SetRegValue(addr, (ushort)value);
                this.PrintTerminal(String.Format("SET %MW[{0}]={1}", addr, (ushort)value));
        }
            // Значение Float Пока не работает
        public void setRegFloatValue(ushort addr, float value)
        {
                con.SetRegValue(addr, (ushort)value);
                this.PrintTerminal(String.Format("SET %MW[{0}]={1}", addr, (ushort)value));            
        }

        private void установитьЗначениеРегистраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRegisterForm regform = new SetRegisterForm();
            regform.OwnerForm = this;
            regform.Show();
        }

        
    }
}
