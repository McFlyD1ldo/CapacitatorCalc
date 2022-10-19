namespace wfCapacitator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.tbTau = new System.Windows.Forms.TextBox();
            this.tbChargeTime = new System.Windows.Forms.TextBox();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.tbResistance = new System.Windows.Forms.TextBox();
            this.tbVoltage = new System.Windows.Forms.TextBox();
            this.clbToDo = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCapacity = new System.Windows.Forms.ComboBox();
            this.cbTau = new System.Windows.Forms.ComboBox();
            this.cbChargeTime = new System.Windows.Forms.ComboBox();
            this.cbCurrent = new System.Windows.Forms.ComboBox();
            this.cbResistance = new System.Windows.Forms.ComboBox();
            this.cbVoltage = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacitor Calculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "supply voltage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "max. current";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "charging time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "pre resistance";
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(139, 126);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.ReadOnly = true;
            this.tbCapacity.Size = new System.Drawing.Size(100, 23);
            this.tbCapacity.TabIndex = 7;
            this.tbCapacity.TextChanged += new System.EventHandler(this.tbCapacity_TextChanged);
            // 
            // tbTau
            // 
            this.tbTau.Location = new System.Drawing.Point(139, 190);
            this.tbTau.Name = "tbTau";
            this.tbTau.ReadOnly = true;
            this.tbTau.Size = new System.Drawing.Size(100, 23);
            this.tbTau.TabIndex = 8;
            this.tbTau.TextChanged += new System.EventHandler(this.tbTau_TextChanged);
            // 
            // tbChargeTime
            // 
            this.tbChargeTime.Location = new System.Drawing.Point(139, 247);
            this.tbChargeTime.Name = "tbChargeTime";
            this.tbChargeTime.ReadOnly = true;
            this.tbChargeTime.Size = new System.Drawing.Size(100, 23);
            this.tbChargeTime.TabIndex = 9;
            this.tbChargeTime.TextChanged += new System.EventHandler(this.tbChargeTime_TextChanged);
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(139, 306);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.ReadOnly = true;
            this.tbCurrent.Size = new System.Drawing.Size(100, 23);
            this.tbCurrent.TabIndex = 10;
            this.tbCurrent.TextChanged += new System.EventHandler(this.tbCurrent_TextChanged);
            // 
            // tbResistance
            // 
            this.tbResistance.Location = new System.Drawing.Point(139, 365);
            this.tbResistance.Name = "tbResistance";
            this.tbResistance.ReadOnly = true;
            this.tbResistance.Size = new System.Drawing.Size(100, 23);
            this.tbResistance.TabIndex = 11;
            this.tbResistance.TextChanged += new System.EventHandler(this.tbResistance_TextChanged);
            // 
            // tbVoltage
            // 
            this.tbVoltage.Location = new System.Drawing.Point(139, 422);
            this.tbVoltage.Name = "tbVoltage";
            this.tbVoltage.ReadOnly = true;
            this.tbVoltage.Size = new System.Drawing.Size(100, 23);
            this.tbVoltage.TabIndex = 12;
            this.tbVoltage.TextChanged += new System.EventHandler(this.tbVoltage_TextChanged);
            // 
            // clbToDo
            // 
            this.clbToDo.BackColor = System.Drawing.SystemColors.Control;
            this.clbToDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbToDo.CheckOnClick = true;
            this.clbToDo.FormattingEnabled = true;
            this.clbToDo.Items.AddRange(new object[] {
            "capacity",
            "tau",
            "charging time",
            "max. current",
            "pre resistance",
            "supply voltage"});
            this.clbToDo.Location = new System.Drawing.Point(423, 162);
            this.clbToDo.Name = "clbToDo";
            this.clbToDo.Size = new System.Drawing.Size(118, 108);
            this.clbToDo.TabIndex = 13;
            this.clbToDo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbToDo_ItemCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(423, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Calculate:";
            // 
            // cbCapacity
            // 
            this.cbCapacity.FormattingEnabled = true;
            this.cbCapacity.Location = new System.Drawing.Point(260, 126);
            this.cbCapacity.Name = "cbCapacity";
            this.cbCapacity.Size = new System.Drawing.Size(90, 23);
            this.cbCapacity.TabIndex = 15;
            // 
            // cbTau
            // 
            this.cbTau.FormattingEnabled = true;
            this.cbTau.Location = new System.Drawing.Point(260, 190);
            this.cbTau.Name = "cbTau";
            this.cbTau.Size = new System.Drawing.Size(90, 23);
            this.cbTau.TabIndex = 16;
            // 
            // cbChargeTime
            // 
            this.cbChargeTime.FormattingEnabled = true;
            this.cbChargeTime.Location = new System.Drawing.Point(260, 247);
            this.cbChargeTime.Name = "cbChargeTime";
            this.cbChargeTime.Size = new System.Drawing.Size(90, 23);
            this.cbChargeTime.TabIndex = 17;
            // 
            // cbCurrent
            // 
            this.cbCurrent.FormattingEnabled = true;
            this.cbCurrent.Location = new System.Drawing.Point(260, 306);
            this.cbCurrent.Name = "cbCurrent";
            this.cbCurrent.Size = new System.Drawing.Size(90, 23);
            this.cbCurrent.TabIndex = 18;
            // 
            // cbResistance
            // 
            this.cbResistance.FormattingEnabled = true;
            this.cbResistance.Location = new System.Drawing.Point(260, 365);
            this.cbResistance.Name = "cbResistance";
            this.cbResistance.Size = new System.Drawing.Size(90, 23);
            this.cbResistance.TabIndex = 19;
            // 
            // cbVoltage
            // 
            this.cbVoltage.FormattingEnabled = true;
            this.cbVoltage.Location = new System.Drawing.Point(260, 422);
            this.cbVoltage.Name = "cbVoltage";
            this.cbVoltage.Size = new System.Drawing.Size(90, 23);
            this.cbVoltage.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbVoltage);
            this.Controls.Add(this.cbResistance);
            this.Controls.Add(this.cbCurrent);
            this.Controls.Add(this.cbChargeTime);
            this.Controls.Add(this.cbTau);
            this.Controls.Add(this.cbCapacity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clbToDo);
            this.Controls.Add(this.tbVoltage);
            this.Controls.Add(this.tbResistance);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.tbChargeTime);
            this.Controls.Add(this.tbTau);
            this.Controls.Add(this.tbCapacity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbCapacity;
        private TextBox tbTau;
        private TextBox tbChargeTime;
        private TextBox tbCurrent;
        private TextBox tbResistance;
        private TextBox tbVoltage;
        private CheckedListBox clbToDo;
        private Label label8;
        private ComboBox cbCapacity;
        private ComboBox cbTau;
        private ComboBox cbChargeTime;
        private ComboBox cbCurrent;
        private ComboBox cbResistance;
        private ComboBox cbVoltage;
        private Button button1;
    }
}