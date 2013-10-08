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
        public string ShowBuff(List<string> strlist)
        {
            if(this.textBox1.Lines.Length>0)
                this.textBox1.Lines[this.textBox1.Lines.Length - 1] = "";
            if (strlist == null) return "";
            if (this.textBox1.Text == "")
            {

                foreach (string str in strlist)
                {
                    textBox1.AppendText(str);
                    textBox1.AppendText("\r\n");
                }

                /*textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;*/
            }
            else
            {
                textBox1.AppendText(strlist[strlist.Count-1]);
                textBox1.AppendText("\r\n");
            }

            textBox1.ScrollToCaret();

            return textBox1.Text;
        }
        /*
        public void SetTerminalText(List<string> strlist)
        {
            this.textBox1.Text = "";
            foreach (string str in strlist)
            {
                textBox1.AppendText(str);
                textBox1.Text = textBox1.Text + "\r\n";
            }
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int anim_i = 0;
        // Анимация таймера
        public void AnimTimer(bool close=false)
        {
            string buf = "|/-\\|/-\\";

            if (anim_i < buf.Length)
            {                
                this.textBox1.Lines[this.textBox1.Lines.Length-1] = buf[anim_i].ToString();             
                anim_i++;
            }
            else
            {
                anim_i = 0;
                this.textBox1.Lines[this.textBox1.Lines.Length - 1] = "";
                // this.textBox1.SelectionLength = 0;
                //this.textBox1.ScrollToCaret();
            }
        }
    }
}
