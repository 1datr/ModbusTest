namespace ModbusTest
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.терминалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupDINTTimer = new System.Windows.Forms.GroupBox();
            this.chbDINTTimer = new System.Windows.Forms.CheckBox();
            this.DINTTimerStep = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupRealTimer = new System.Windows.Forms.GroupBox();
            this.chbRealTimer = new System.Windows.Forms.CheckBox();
            this.tbRealTimerStep = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.tbRealAddr2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbRealAddr1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.разноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьЗначениеРегистраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupDINTTimer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupRealTimer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 273);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеToolStripMenuItem,
            this.разноеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главноеToolStripMenuItem
            // 
            this.главноеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соединитьсяToolStripMenuItem,
            this.терминалToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.главноеToolStripMenuItem.Name = "главноеToolStripMenuItem";
            this.главноеToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.главноеToolStripMenuItem.Text = "Главное";
            // 
            // соединитьсяToolStripMenuItem
            // 
            this.соединитьсяToolStripMenuItem.Name = "соединитьсяToolStripMenuItem";
            this.соединитьсяToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.соединитьсяToolStripMenuItem.Text = "Соединиться";
            this.соединитьсяToolStripMenuItem.Click += new System.EventHandler(this.соединитьсяToolStripMenuItem_Click);
            // 
            // терминалToolStripMenuItem
            // 
            this.терминалToolStripMenuItem.Name = "терминалToolStripMenuItem";
            this.терминалToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.терминалToolStripMenuItem.Text = "Терминал";
            this.терминалToolStripMenuItem.Click += new System.EventHandler(this.терминалToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 24);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(378, 249);
            this.TabControl.TabIndex = 2;
            this.TabControl.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupDINTTimer);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DINT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupDINTTimer
            // 
            this.groupDINTTimer.Controls.Add(this.chbDINTTimer);
            this.groupDINTTimer.Controls.Add(this.DINTTimerStep);
            this.groupDINTTimer.Enabled = false;
            this.groupDINTTimer.Location = new System.Drawing.Point(3, 6);
            this.groupDINTTimer.Name = "groupDINTTimer";
            this.groupDINTTimer.Size = new System.Drawing.Size(146, 52);
            this.groupDINTTimer.TabIndex = 6;
            this.groupDINTTimer.TabStop = false;
            // 
            // chbDINTTimer
            // 
            this.chbDINTTimer.AutoSize = true;
            this.chbDINTTimer.Location = new System.Drawing.Point(6, 19);
            this.chbDINTTimer.Name = "chbDINTTimer";
            this.chbDINTTimer.Size = new System.Drawing.Size(65, 17);
            this.chbDINTTimer.TabIndex = 4;
            this.chbDINTTimer.Text = "Таймер";
            this.chbDINTTimer.UseVisualStyleBackColor = true;
            this.chbDINTTimer.CheckedChanged += new System.EventHandler(this.chbDINTTimer_CheckedChanged);
            // 
            // DINTTimerStep
            // 
            this.DINTTimerStep.Location = new System.Drawing.Point(77, 19);
            this.DINTTimerStep.Name = "DINTTimerStep";
            this.DINTTimerStep.Size = new System.Drawing.Size(49, 20);
            this.DINTTimerStep.TabIndex = 5;
            this.DINTTimerStep.Text = "100";
            this.DINTTimerStep.TextChanged += new System.EventHandler(this.DINTTimerStep_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 25);
            this.panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(3, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 125);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Адрес";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Значение";
            this.Column2.Name = "Column2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupRealTimer);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "REAL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupRealTimer
            // 
            this.groupRealTimer.Controls.Add(this.chbRealTimer);
            this.groupRealTimer.Controls.Add(this.tbRealTimerStep);
            this.groupRealTimer.Enabled = false;
            this.groupRealTimer.Location = new System.Drawing.Point(3, 0);
            this.groupRealTimer.Name = "groupRealTimer";
            this.groupRealTimer.Size = new System.Drawing.Size(146, 52);
            this.groupRealTimer.TabIndex = 7;
            this.groupRealTimer.TabStop = false;
            // 
            // chbRealTimer
            // 
            this.chbRealTimer.AutoSize = true;
            this.chbRealTimer.Location = new System.Drawing.Point(6, 19);
            this.chbRealTimer.Name = "chbRealTimer";
            this.chbRealTimer.Size = new System.Drawing.Size(65, 17);
            this.chbRealTimer.TabIndex = 4;
            this.chbRealTimer.Text = "Таймер";
            this.chbRealTimer.UseVisualStyleBackColor = true;
            this.chbRealTimer.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbRealTimerStep
            // 
            this.tbRealTimerStep.Location = new System.Drawing.Point(77, 19);
            this.tbRealTimerStep.Name = "tbRealTimerStep";
            this.tbRealTimerStep.Size = new System.Drawing.Size(49, 20);
            this.tbRealTimerStep.TabIndex = 5;
            this.tbRealTimerStep.Text = "100";
            this.tbRealTimerStep.TextChanged += new System.EventHandler(this.tbRealTimerStep_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbFormat);
            this.panel2.Controls.Add(this.tbRealAddr2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.tbRealAddr1);
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 25);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Формат:";
            // 
            // tbFormat
            // 
            this.tbFormat.Location = new System.Drawing.Point(226, 2);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(41, 20);
            this.tbFormat.TabIndex = 4;
            this.tbFormat.Text = "F2";
            // 
            // tbRealAddr2
            // 
            this.tbRealAddr2.Location = new System.Drawing.Point(90, 2);
            this.tbRealAddr2.Name = "tbRealAddr2";
            this.tbRealAddr2.Size = new System.Drawing.Size(81, 20);
            this.tbRealAddr2.TabIndex = 3;
            this.tbRealAddr2.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Показать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbRealAddr1
            // 
            this.tbRealAddr1.Location = new System.Drawing.Point(3, 3);
            this.tbRealAddr1.Name = "tbRealAddr1";
            this.tbRealAddr1.Size = new System.Drawing.Size(81, 20);
            this.tbRealAddr1.TabIndex = 2;
            this.tbRealAddr1.Text = "0";
            this.tbRealAddr1.TextChanged += new System.EventHandler(this.tbRealAddr1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(3, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(367, 137);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Адрес";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Значение";
            this.Column4.Name = "Column4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // разноеToolStripMenuItem
            // 
            this.разноеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.установитьЗначениеРегистраToolStripMenuItem});
            this.разноеToolStripMenuItem.Name = "разноеToolStripMenuItem";
            this.разноеToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.разноеToolStripMenuItem.Text = "Разное";
            // 
            // установитьЗначениеРегистраToolStripMenuItem
            // 
            this.установитьЗначениеРегистраToolStripMenuItem.Name = "установитьЗначениеРегистраToolStripMenuItem";
            this.установитьЗначениеРегистраToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.установитьЗначениеРегистраToolStripMenuItem.Text = "Установить значение регистра";
            this.установитьЗначениеРегистраToolStripMenuItem.Click += new System.EventHandler(this.установитьЗначениеРегистраToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 295);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Modbus Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupDINTTimer.ResumeLayout(false);
            this.groupDINTTimer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupRealTimer.ResumeLayout(false);
            this.groupRealTimer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединитьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbRealAddr2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbRealAddr1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupDINTTimer;
        private System.Windows.Forms.CheckBox chbDINTTimer;
        private System.Windows.Forms.TextBox DINTTimerStep;
        private System.Windows.Forms.GroupBox groupRealTimer;
        private System.Windows.Forms.CheckBox chbRealTimer;
        private System.Windows.Forms.TextBox tbRealTimerStep;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFormat;
        private System.Windows.Forms.ToolStripMenuItem терминалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьЗначениеРегистраToolStripMenuItem;


    }
}

