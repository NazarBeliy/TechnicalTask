namespace test_task
{
    partial class NewUserAdding
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
            this.AddNewUserButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TaxIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Location = new System.Drawing.Point(62, 433);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(287, 45);
            this.AddNewUserButton.TabIndex = 0;
            this.AddNewUserButton.Text = "Додати";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(57, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 349);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(292, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(292, 20);
            this.textBox4.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(206, 45);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(148, 13);
            this.Name.TabIndex = 6;
            this.Name.Text = "Призвище, ім\'я, по батькові";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(262, 133);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(92, 13);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.Text = "Номер телефону";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(253, 240);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(101, 13);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Електронна пошта";
            // 
            // TaxIDLabel
            // 
            this.TaxIDLabel.AutoSize = true;
            this.TaxIDLabel.Location = new System.Drawing.Point(226, 333);
            this.TaxIDLabel.Name = "TaxIDLabel";
            this.TaxIDLabel.Size = new System.Drawing.Size(128, 13);
            this.TaxIDLabel.TabIndex = 12;
            this.TaxIDLabel.Text = "Ідентифікаційний номер";
            // 
            // NewUserAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 497);
            this.Controls.Add(this.TaxIDLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddNewUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ShowIcon = false;
            this.Text = "Створення нового користувача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TaxIDLabel;
    }
}