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
            if (this.TerminalStrings == null) this.TerminalStrings = new List<string>();

            string newstr = "[" + System.DateTime.Now + "] " + str;

            using (FileStream fs = new FileStream("ModbusTest.log", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(newstr);
                }
            }

            this.TerminalStrings.Add(newstr);

            if (terminalform.Visible)
                terminalform.ShowBuff(this.TerminalStrings);
        }
        
        private bool INT_MODE_TIMER;
        private void button1_Click(object sender, EventArgs e)
        {
            INT_MODE_TIMER = false;
            WatchDINTValues();
        }

        // просмотр в целых числах
        private void WatchDINTValues()
        {
            // векторы с числами
            UshortList = new List<ushort>();
            if (INT_MODE_TIMER)
            {
                if (OldUshortList == null)
                    OldUshortList = new List<ushort>();
            }
            else
                OldUshortList = new List<ushort>();
            groupDINTTimer.Enabled = true;
            timer1.Enabled = false;
            // получить числа из регистров            
            dataGridView1.Rows.Clear();
            for (ushort regaddr = ushort.Parse(textBox1.Text); regaddr <= ushort.Parse(textBox2.Text); regaddr += 2)
            {
                ushort regval = con.Reg(regaddr);
                dataGridView1.Rows.Add(regaddr.ToString(), regval.ToString());
                UshortList.Add(regval);           
                // анимация
                if(this.terminalform.Visible)
                    this.terminalform.AnimTimer();
            }
            // если есть изменения в показаниях
            if (!UshortList.SequenceEqual<ushort>(OldUshortList))
            {
                ushort regaddr = ushort.Parse(textBox1.Text);
                foreach (ushort regval in UshortList)
                {
                    PrintTerminal(String.Format("%MW{0} = {1}", regaddr.ToString(), regval.ToString()));
                    regaddr += 2;
                }
                OldUshortList = UshortList;
            }
            
        }

        private bool REAL_MODE_TIMER = false;
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
            REAL_MODE_TIMER = true;
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

        private List<float> OldFloatList;    // Старый список Ushort-ов
        private List<float> FloatList;    // Список Ushort-ов
        // Просмотр в формате чисел с плавающей запятой
        private void WatchRealValues()
        {
            // векторы с числами
            FloatList = new List<float>();
            if (OldFloatList == null)
                OldFloatList = new List<float>();
            // получить числа из регистров
            groupRealTimer.Enabled = true;
            timer2.Enabled = false;
            for (ushort regaddr = ushort.Parse(this.tbRealAddr1.Text); regaddr <= ushort.Parse(this.tbRealAddr2.Text); regaddr+=4)
            {
                ushort[] temp = new ushort[2];
                temp[1] = con.Reg(regaddr);
                temp[0] = con.Reg((ushort)(regaddr+2));
                float val = _2words2float(temp);
                FloatList.Add(val);           
                // анимация
                if(this.terminalform.Visible)
                    this.terminalform.AnimTimer();
            }

            // если есть изменения в показаниях
            if (!FloatList.SequenceEqual<float>(OldFloatList))
            {
                ushort regaddr = ushort.Parse(this.tbRealAddr1.Text);
                dataGridView2.Rows.Clear();
                foreach (float val in FloatList)
                {
                    string Format = tbFormat.Text;
                    string strval;
                    try
                    {
                        strval = val.ToString(Format);
                    }
                    catch (Exception e)
                    {
                        strval = val.ToString("F6");
                    }
                    PrintTerminal(String.Format("%MW{0} = {1}", regaddr.ToString(), strval));
                    dataGridView2.Rows.Add(regaddr.ToString(), strval);
                    regaddr += 4;
                }
            }

            OldFloatList = FloatList;
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

        private List<ushort> OldUshortList;    // Старый список Ushort-ов
        private List<ushort> UshortList;    // Список Ushort-ов
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            INT_MODE_TIMER = true;
            WatchDINTValues();
            timer1.Enabled = true;
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
            timer2.Enabled = false;
            REAL_MODE_TIMER = true;
            WatchRealValues();
            timer2.Enabled = true;
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
            terminalform = new TerminalForm();            
            terminalform.Owner = this;
            terminalform.Show();
            terminalform.ShowBuff(this.TerminalStrings);
        }

        private List<string> TerminalStrings;

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
