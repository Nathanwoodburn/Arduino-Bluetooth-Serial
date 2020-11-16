namespace Arduino_Bluetooth_Serial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new DarkUI.Controls.DarkButton();
            this.label1 = new DarkUI.Controls.DarkLabel();
            this.textBox1 = new DarkUI.Controls.DarkTextBox();
            this.label2 = new DarkUI.Controls.DarkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new DarkUI.Controls.DarkTextBox();
            this.button2 = new DarkUI.Controls.DarkButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new DarkUI.Controls.DarkButton();
            this.label3 = new DarkUI.Controls.DarkLabel();
            this.button4 = new DarkUI.Controls.DarkButton();
            this.button5 = new DarkUI.Controls.DarkButton();
            this.button6 = new DarkUI.Controls.DarkButton();
            this.button7 = new DarkUI.Controls.DarkButton();
            this.button8 = new DarkUI.Controls.DarkButton();
            this.button9 = new DarkUI.Controls.DarkButton();
            this.button10 = new DarkUI.Controls.DarkButton();
            this.button11 = new DarkUI.Controls.DarkButton();
            this.button12 = new DarkUI.Controls.DarkButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button16 = new DarkUI.Controls.DarkButton();
            this.button15 = new DarkUI.Controls.DarkButton();
            this.button13 = new DarkUI.Controls.DarkButton();
            this.button19 = new DarkUI.Controls.DarkButton();
            this.groupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.button21 = new DarkUI.Controls.DarkButton();
            this.button20 = new DarkUI.Controls.DarkButton();
            this.button18 = new DarkUI.Controls.DarkButton();
            this.button17 = new DarkUI.Controls.DarkButton();
            this.button14 = new DarkUI.Controls.DarkButton();
            this.comboBox1 = new DarkUI.Controls.DarkComboBox();
            this.groupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.groupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not Connected";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBox1.Location = new System.Drawing.Point(330, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "COM1";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(213, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(469, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(471, 350);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 17);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Send";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 19);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.TabStop = false;
            this.button3.Text = "Disconnect";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(865, 359);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5);
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Clear";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 6);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5);
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Servo Attach";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(87, 6);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(5);
            this.button6.Size = new System.Drawing.Size(82, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Servo Detach";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 35);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(5);
            this.button7.Size = new System.Drawing.Size(68, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Servo 0°";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(73, 35);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(5);
            this.button8.Size = new System.Drawing.Size(68, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Servo 45°";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(140, 35);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(5);
            this.button9.Size = new System.Drawing.Size(68, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Servo 90°";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(274, 35);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(5);
            this.button10.Size = new System.Drawing.Size(68, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Servo 180°";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(207, 35);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(5);
            this.button11.Size = new System.Drawing.Size(68, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "Servo 135°";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(300, 19);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(5);
            this.button12.Size = new System.Drawing.Size(50, 23);
            this.button12.TabIndex = 11;
            this.button12.Text = "Sonar";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(312, 463);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 157);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(348, 131);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drive";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(348, 131);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(127, 77);
            this.button16.Name = "button16";
            this.button16.Padding = new System.Windows.Forms.Padding(5);
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 3;
            this.button16.Text = "Right";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(30, 77);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(5);
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 2;
            this.button15.Text = "Left";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(39, 19);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(5);
            this.button13.Size = new System.Drawing.Size(148, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "Forward (autocorrect)";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(300, 48);
            this.button19.Name = "button19";
            this.button19.Padding = new System.Windows.Forms.Padding(5);
            this.button19.Size = new System.Drawing.Size(50, 23);
            this.button19.TabIndex = 14;
            this.button19.Text = "Auto";
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 176);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkeys";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(78, 135);
            this.button21.Name = "button21";
            this.button21.Padding = new System.Windows.Forms.Padding(5);
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 19;
            this.button21.Text = "Reverse";
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(300, 106);
            this.button20.Name = "button20";
            this.button20.Padding = new System.Windows.Forms.Padding(5);
            this.button20.Size = new System.Drawing.Size(50, 23);
            this.button20.TabIndex = 18;
            this.button20.Text = "Info";
            this.button20.Click += new System.EventHandler(this.button20_Click_2);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(78, 48);
            this.button18.Name = "button18";
            this.button18.Padding = new System.Windows.Forms.Padding(5);
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 17;
            this.button18.Text = "Forward";
            this.button18.Click += new System.EventHandler(this.button18_Click_2);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(300, 77);
            this.button17.Name = "button17";
            this.button17.Padding = new System.Windows.Forms.Padding(5);
            this.button17.Size = new System.Drawing.Size(50, 23);
            this.button17.TabIndex = 16;
            this.button17.Text = "Help";
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(70, 106);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(5);
            this.button14.Size = new System.Drawing.Size(92, 23);
            this.button14.TabIndex = 4;
            this.button14.Text = "Turn around";
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 64);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // groupBox3
            // 
            this.groupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(3, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 45);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 399);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arduino BT Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkButton button1;
        private DarkUI.Controls.DarkLabel label1;
        private DarkUI.Controls.DarkTextBox textBox1;
        private DarkUI.Controls.DarkLabel label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DarkUI.Controls.DarkTextBox textBox2;
        private DarkUI.Controls.DarkButton button2;
        private System.Windows.Forms.Timer timer1;
        private DarkUI.Controls.DarkButton button3;
        private DarkUI.Controls.DarkLabel label3;
        private DarkUI.Controls.DarkButton button4;
        private DarkUI.Controls.DarkButton button5;
        private DarkUI.Controls.DarkButton button6;
        private DarkUI.Controls.DarkButton button7;
        private DarkUI.Controls.DarkButton button8;
        private DarkUI.Controls.DarkButton button9;
        private DarkUI.Controls.DarkButton button10;
        private DarkUI.Controls.DarkButton button11;
        private DarkUI.Controls.DarkButton button12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DarkUI.Controls.DarkGroupBox groupBox1;
        private DarkUI.Controls.DarkButton button16;
        private DarkUI.Controls.DarkButton button15;
        private DarkUI.Controls.DarkButton button13;
        private DarkUI.Controls.DarkButton button19;
        private DarkUI.Controls.DarkComboBox comboBox1;
        private DarkUI.Controls.DarkGroupBox groupBox2;
        private DarkUI.Controls.DarkGroupBox groupBox3;
        private DarkUI.Controls.DarkButton button14;
        private DarkUI.Controls.DarkButton button17;
        private DarkUI.Controls.DarkButton button18;
        private DarkUI.Controls.DarkButton button20;
        private DarkUI.Controls.DarkButton button21;
    }
}

