namespace ResistorCalculator
{
    internal sealed partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calcvalbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bandc6 = new System.Windows.Forms.RadioButton();
            this.bandc5 = new System.Windows.Forms.RadioButton();
            this.bandc3 = new System.Windows.Forms.RadioButton();
            this.bandc4 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.band6 = new System.Windows.Forms.ComboBox();
            this.band5 = new System.Windows.Forms.ComboBox();
            this.band4 = new System.Windows.Forms.ComboBox();
            this.band3 = new System.Windows.Forms.ComboBox();
            this.band2 = new System.Windows.Forms.ComboBox();
            this.band1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.outputcontext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tolerance = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resistancevalue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.calccolorbtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gohm = new System.Windows.Forms.RadioButton();
            this.mohm = new System.Windows.Forms.RadioButton();
            this.ohm = new System.Windows.Forms.RadioButton();
            this.kohm = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.outputcontext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resistancevalue)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcvalbtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.band6);
            this.groupBox1.Controls.Add(this.band5);
            this.groupBox1.Controls.Add(this.band4);
            this.groupBox1.Controls.Add(this.band3);
            this.groupBox1.Controls.Add(this.band2);
            this.groupBox1.Controls.Add(this.band1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color to Value";
            // 
            // calcvalbtn
            // 
            this.calcvalbtn.Location = new System.Drawing.Point(183, 136);
            this.calcvalbtn.Name = "calcvalbtn";
            this.calcvalbtn.Size = new System.Drawing.Size(82, 39);
            this.calcvalbtn.TabIndex = 0;
            this.calcvalbtn.Text = "Calculate";
            this.calcvalbtn.UseVisualStyleBackColor = true;
            this.calcvalbtn.Click += new System.EventHandler(this.CalcvalbtnClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bandc6);
            this.groupBox2.Controls.Add(this.bandc5);
            this.groupBox2.Controls.Add(this.bandc3);
            this.groupBox2.Controls.Add(this.bandc4);
            this.groupBox2.Location = new System.Drawing.Point(183, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(82, 111);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bands";
            // 
            // bandc6
            // 
            this.bandc6.AutoSize = true;
            this.bandc6.Location = new System.Drawing.Point(6, 88);
            this.bandc6.Name = "bandc6";
            this.bandc6.Size = new System.Drawing.Size(64, 17);
            this.bandc6.TabIndex = 11;
            this.bandc6.Text = "6-Bands";
            this.bandc6.UseVisualStyleBackColor = true;
            this.bandc6.CheckedChanged += new System.EventHandler(this.BandCountChanged);
            // 
            // bandc5
            // 
            this.bandc5.AutoSize = true;
            this.bandc5.Location = new System.Drawing.Point(6, 65);
            this.bandc5.Name = "bandc5";
            this.bandc5.Size = new System.Drawing.Size(64, 17);
            this.bandc5.TabIndex = 10;
            this.bandc5.Text = "5-Bands";
            this.bandc5.UseVisualStyleBackColor = true;
            this.bandc5.CheckedChanged += new System.EventHandler(this.BandCountChanged);
            // 
            // bandc3
            // 
            this.bandc3.AutoSize = true;
            this.bandc3.Checked = true;
            this.bandc3.Location = new System.Drawing.Point(6, 19);
            this.bandc3.Name = "bandc3";
            this.bandc3.Size = new System.Drawing.Size(64, 17);
            this.bandc3.TabIndex = 8;
            this.bandc3.TabStop = true;
            this.bandc3.Text = "3-Bands";
            this.bandc3.UseVisualStyleBackColor = true;
            this.bandc3.CheckedChanged += new System.EventHandler(this.BandCountChanged);
            // 
            // bandc4
            // 
            this.bandc4.AutoSize = true;
            this.bandc4.Location = new System.Drawing.Point(6, 42);
            this.bandc4.Name = "bandc4";
            this.bandc4.Size = new System.Drawing.Size(64, 17);
            this.bandc4.TabIndex = 9;
            this.bandc4.Text = "4-Bands";
            this.bandc4.UseVisualStyleBackColor = true;
            this.bandc4.CheckedChanged += new System.EventHandler(this.BandCountChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Band 6:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Band 5:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Band 4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Band 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Band 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Band 1:";
            // 
            // band6
            // 
            this.band6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.band6.Enabled = false;
            this.band6.FormattingEnabled = true;
            this.band6.Location = new System.Drawing.Point(56, 154);
            this.band6.Name = "band6";
            this.band6.Size = new System.Drawing.Size(121, 21);
            this.band6.TabIndex = 6;
            // 
            // band5
            // 
            this.band5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.band5.Enabled = false;
            this.band5.FormattingEnabled = true;
            this.band5.Location = new System.Drawing.Point(56, 127);
            this.band5.Name = "band5";
            this.band5.Size = new System.Drawing.Size(121, 21);
            this.band5.TabIndex = 5;
            // 
            // band4
            // 
            this.band4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.band4.Enabled = false;
            this.band4.FormattingEnabled = true;
            this.band4.Location = new System.Drawing.Point(56, 100);
            this.band4.Name = "band4";
            this.band4.Size = new System.Drawing.Size(121, 21);
            this.band4.TabIndex = 4;
            // 
            // band3
            // 
            this.band3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.band3.FormattingEnabled = true;
            this.band3.Location = new System.Drawing.Point(56, 73);
            this.band3.Name = "band3";
            this.band3.Size = new System.Drawing.Size(121, 21);
            this.band3.TabIndex = 3;
            // 
            // band2
            // 
            this.band2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.band2.FormattingEnabled = true;
            this.band2.Location = new System.Drawing.Point(56, 46);
            this.band2.Name = "band2";
            this.band2.Size = new System.Drawing.Size(121, 21);
            this.band2.TabIndex = 2;
            // 
            // band1
            // 
            this.band1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.band1.FormattingEnabled = true;
            this.band1.Location = new System.Drawing.Point(56, 19);
            this.band1.Name = "band1";
            this.band1.Size = new System.Drawing.Size(121, 21);
            this.band1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.output);
            this.groupBox3.Controls.Add(this.tolerance);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.resistancevalue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.calccolorbtn);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(289, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 181);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Value to Colors";
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.ContextMenuStrip = this.outputcontext;
            this.output.DetectUrls = false;
            this.output.Location = new System.Drawing.Point(110, 95);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(112, 77);
            this.output.TabIndex = 17;
            this.output.Text = "";
            this.output.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OutputMouseClick);
            // 
            // outputcontext
            // 
            this.outputcontext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.outputcontext.Name = "contextMenuStrip1";
            this.outputcontext.Size = new System.Drawing.Size(103, 26);
            this.outputcontext.Opening += new System.ComponentModel.CancelEventHandler(this.OutputcontextOpening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopySelectedOutputText);
            // 
            // tolerance
            // 
            this.tolerance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tolerance.FormattingEnabled = true;
            this.tolerance.Location = new System.Drawing.Point(110, 68);
            this.tolerance.Name = "tolerance";
            this.tolerance.Size = new System.Drawing.Size(112, 21);
            this.tolerance.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tolerance:";
            // 
            // resistancevalue
            // 
            this.resistancevalue.Location = new System.Drawing.Point(150, 22);
            this.resistancevalue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.resistancevalue.Name = "resistancevalue";
            this.resistancevalue.Size = new System.Drawing.Size(72, 20);
            this.resistancevalue.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Value:";
            // 
            // calccolorbtn
            // 
            this.calccolorbtn.Location = new System.Drawing.Point(6, 136);
            this.calccolorbtn.Name = "calccolorbtn";
            this.calccolorbtn.Size = new System.Drawing.Size(98, 36);
            this.calccolorbtn.TabIndex = 0;
            this.calccolorbtn.Text = "Calculate";
            this.calccolorbtn.UseVisualStyleBackColor = true;
            this.calccolorbtn.Click += new System.EventHandler(this.CalccolorbtnClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gohm);
            this.groupBox5.Controls.Add(this.mohm);
            this.groupBox5.Controls.Add(this.ohm);
            this.groupBox5.Controls.Add(this.kohm);
            this.groupBox5.Location = new System.Drawing.Point(9, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(95, 111);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // gohm
            // 
            this.gohm.AutoSize = true;
            this.gohm.Location = new System.Drawing.Point(6, 88);
            this.gohm.Name = "gohm";
            this.gohm.Size = new System.Drawing.Size(81, 17);
            this.gohm.TabIndex = 11;
            this.gohm.Text = "GΩ (GOhm)";
            this.gohm.UseVisualStyleBackColor = true;
            // 
            // mohm
            // 
            this.mohm.AutoSize = true;
            this.mohm.Location = new System.Drawing.Point(6, 65);
            this.mohm.Name = "mohm";
            this.mohm.Size = new System.Drawing.Size(83, 17);
            this.mohm.TabIndex = 10;
            this.mohm.Text = "MΩ (MOhm)";
            this.mohm.UseVisualStyleBackColor = true;
            // 
            // ohm
            // 
            this.ohm.AutoSize = true;
            this.ohm.Checked = true;
            this.ohm.Location = new System.Drawing.Point(6, 19);
            this.ohm.Name = "ohm";
            this.ohm.Size = new System.Drawing.Size(65, 17);
            this.ohm.TabIndex = 8;
            this.ohm.TabStop = true;
            this.ohm.Text = "Ω (Ohm)";
            this.ohm.UseVisualStyleBackColor = true;
            this.ohm.CheckedChanged += new System.EventHandler(this.OhmChanged);
            // 
            // kohm
            // 
            this.kohm.AutoSize = true;
            this.kohm.Location = new System.Drawing.Point(6, 42);
            this.kohm.Name = "kohm";
            this.kohm.Size = new System.Drawing.Size(79, 17);
            this.kohm.TabIndex = 9;
            this.kohm.Text = "KΩ (KOhm)";
            this.kohm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 208);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.outputcontext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resistancevalue)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton bandc4;
        private System.Windows.Forms.RadioButton bandc6;
        private System.Windows.Forms.RadioButton bandc5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox band6;
        private System.Windows.Forms.ComboBox band5;
        private System.Windows.Forms.ComboBox band4;
        private System.Windows.Forms.ComboBox band3;
        private System.Windows.Forms.ComboBox band2;
        private System.Windows.Forms.ComboBox band1;
        private System.Windows.Forms.Button calcvalbtn;
        private System.Windows.Forms.RadioButton bandc3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button calccolorbtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton gohm;
        private System.Windows.Forms.RadioButton mohm;
        private System.Windows.Forms.RadioButton ohm;
        private System.Windows.Forms.RadioButton kohm;
        private System.Windows.Forms.NumericUpDown resistancevalue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tolerance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.ContextMenuStrip outputcontext;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}

