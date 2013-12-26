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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 208);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

