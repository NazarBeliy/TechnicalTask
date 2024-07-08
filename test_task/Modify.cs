using System;
using System.Windows.Forms;
using test_task.WorkingService;
namespace test_task
{
    public partial class Modify : Form
    {
        private static UsersTable instance;
        private static User OldData;
        private static User NewData;
        public Modify(User user)
        {
            InitializeComponent();
            Start(user);
        }
        void Start(User user)
        {
            OldData = user;
            Fill(OldData);
            instance = UsersTable.ReturnInstance();
        }

        private void Fill(User user)
        {
            dataGridView1.Rows.Add(user.Name, user.PhoneNumber, user.Email, user.TaxId);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[0];

            string name = row.Cells["Name"].Value.ToString();
            string phoneNumber = row.Cells["PhoneNumber"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            string taxId = row.Cells["TaxID"].Value.ToString();

            NewData = new User
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Email = email,
                TaxId = taxId,
                Updated = DateTime.Now
            };

            instance.UpdateUser(OldData, NewData);
            Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
