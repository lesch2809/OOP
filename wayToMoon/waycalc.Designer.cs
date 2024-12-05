namespace wayToMoon
{
    partial class waycalc
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
            this.in_days = new System.Windows.Forms.RadioButton();
            this.in_h = new System.Windows.Forms.RadioButton();
            this.km_h = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // in_days
            // 
            this.in_days.AutoSize = true;
            this.in_days.Location = new System.Drawing.Point(221, 135);
            this.in_days.Name = "in_days";
            this.in_days.Size = new System.Drawing.Size(95, 24);
            this.in_days.TabIndex = 0;
            this.in_days.TabStop = true;
            this.in_days.Text = "in Tagen";
            this.in_days.UseVisualStyleBackColor = true;
            // 
            // in_h
            // 
            this.in_h.AutoSize = true;
            this.in_h.Location = new System.Drawing.Point(357, 135);
            this.in_h.Name = "in_h";
            this.in_h.Size = new System.Drawing.Size(111, 24);
            this.in_h.TabIndex = 1;
            this.in_h.TabStop = true;
            this.in_h.Text = "in Stunden";
            this.in_h.UseVisualStyleBackColor = true;
            // 
            // km_h
            // 
            this.km_h.Location = new System.Drawing.Point(500, 198);
            this.km_h.Name = "km_h";
            this.km_h.Size = new System.Drawing.Size(100, 26);
            this.km_h.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geschwindigkeit in KM/H";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(221, 279);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(379, 35);
            this.calc.TabIndex = 4;
            this.calc.Text = "Reisedauer berechnen";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reisedauer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            // 
            // waycalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 429);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.km_h);
            this.Controls.Add(this.in_h);
            this.Controls.Add(this.in_days);
            this.Name = "waycalc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton in_days;
        private System.Windows.Forms.RadioButton in_h;
        private System.Windows.Forms.TextBox km_h;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

