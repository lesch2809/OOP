namespace kontakt_manager
{
    partial class kontakte
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.delet_button = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(4, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuer Kontakt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(755, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(755, 26);
            this.textBox3.TabIndex = 3;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(11, 217);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(55, 20);
            this.phone.TabIndex = 2;
            this.phone.Text = "Phone";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(11, 133);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(37, 20);
            this.mail.TabIndex = 1;
            this.mail.Text = "Mail";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(11, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // delet_button
            // 
            this.delet_button.Location = new System.Drawing.Point(40, 31);
            this.delet_button.Name = "delet_button";
            this.delet_button.Size = new System.Drawing.Size(141, 46);
            this.delet_button.TabIndex = 1;
            this.delet_button.Text = "Liste Löschen";
            this.delet_button.UseVisualStyleBackColor = true;
            // 
            // import_button
            // 
            this.import_button.Location = new System.Drawing.Point(351, 31);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(143, 46);
            this.import_button.TabIndex = 2;
            this.import_button.Text = "Import CSV";
            this.import_button.UseVisualStyleBackColor = true;
            // 
            // export_button
            // 
            this.export_button.Location = new System.Drawing.Point(612, 31);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(132, 46);
            this.export_button.TabIndex = 3;
            this.export_button.Text = "Export CSV";
            this.export_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(840, 283);
            this.dataGridView1.TabIndex = 4;
            // 
            // kontakte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 688);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.import_button);
            this.Controls.Add(this.delet_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "kontakte";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button delet_button;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

