namespace test_task
{
    partial class UsersTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddNewUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NS,
            this.PN,
            this.email,
            this.SRNP,
            this.CD,
            this.LTCD,
            this.Delete,
            this.Change});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1557, 671);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NS
            // 
            this.NS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NS.HeaderText = "ПІБ";
            this.NS.Name = "NS";
            this.NS.ReadOnly = true;
            this.NS.Width = 50;
            // 
            // PN
            // 
            this.PN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PN.HeaderText = "Номер телефону";
            this.PN.Name = "PN";
            this.PN.ReadOnly = true;
            this.PN.Width = 107;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.HeaderText = "Пошта";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 65;
            // 
            // SRNP
            // 
            this.SRNP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SRNP.HeaderText = "ДРФО";
            this.SRNP.Name = "SRNP";
            this.SRNP.ReadOnly = true;
            this.SRNP.Width = 67;
            // 
            // CD
            // 
            this.CD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CD.HeaderText = "Дата Створення";
            this.CD.Name = "CD";
            this.CD.ReadOnly = true;
            this.CD.Width = 106;
            // 
            // LTCD
            // 
            this.LTCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LTCD.HeaderText = "Дата останньої зміни даних";
            this.LTCD.Name = "LTCD";
            this.LTCD.ReadOnly = true;
            this.LTCD.Width = 133;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Видалити";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Видалити";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Change
            // 
            this.Change.HeaderText = "Змінити";
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            this.Change.Text = "Змінити";
            this.Change.UseColumnTextForButtonValue = true;
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Location = new System.Drawing.Point(588, 679);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(406, 48);
            this.AddNewUserButton.TabIndex = 1;
            this.AddNewUserButton.Text = "Додати нового користувача";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 739);
            this.Controls.Add(this.AddNewUserButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UsersTable";
            this.ShowIcon = false;
            this.Text = "Таблиця данних з користувачами";
            this.Load += new System.EventHandler(this.UsersTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddNewUserButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LTCD;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
    }
}

