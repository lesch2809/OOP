﻿namespace dice
{
    partial class dice
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
            this.button1 = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.Label();
            this.numold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(409, 407);
            this.button1.TabIndex = 0;
            this.button1.Text = "Würfeln";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(801, 235);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(194, 91);
            this.num.TabIndex = 1;
            this.num.Text = "num";
            // 
            // numold
            // 
            this.numold.AutoSize = true;
            this.numold.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numold.Location = new System.Drawing.Point(809, 503);
            this.numold.Name = "numold";
            this.numold.Size = new System.Drawing.Size(151, 46);
            this.numold.TabIndex = 2;
            this.numold.Text = "numold";
            // 
            // dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 804);
            this.Controls.Add(this.numold);
            this.Controls.Add(this.num);
            this.Controls.Add(this.button1);
            this.Name = "dice";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label numold;
    }
}

