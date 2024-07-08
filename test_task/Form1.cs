using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_task.WorkingService;

namespace test_task
{
    public partial class UsersTable : Form, IService1
    {
        public static Service1Client client;
        private static UsersTable instance;
        public static UsersTable ReturnInstance()
        {
            return instance;
        }

        public UsersTable()
        {
            InitializeComponent();
            instance = this;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                {
                    return;
                }

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (e.ColumnIndex == 6) // Перевіряємо, якщо натиснуто кнопку видалення в шостому стовпці
                {
                    User userToDelete = new User
                    {
                        Name = row.Cells["NS"].Value?.ToString(),
                        PhoneNumber = row.Cells["PN"].Value?.ToString(),
                        Email = row.Cells["email"].Value?.ToString(),
                        TaxId = row.Cells["SRNP"].Value?.ToString()
                    };
                    client.DeleteUser(userToDelete); // Виклик методу WCF видалення користувача
                    dataGridView1.Rows.RemoveAt(e.RowIndex); // Видалення рядка з DataGridView
                    return;
                }
                if (e.ColumnIndex == 7) // Перевіряємо, якщо натиснуто кнопку видалення в шостому стовпці
                {
                    // Перевірка на наявність даних у осередках перед відкриттям вікна редагування
                    string name = row.Cells["NS"].Value?.ToString();
                    string phoneNumber = row.Cells["PN"].Value?.ToString();
                    string email = row.Cells["email"].Value?.ToString();
                    string taxId = row.Cells["SRNP"].Value?.ToString();

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber) ||
                        string.IsNullOrEmpty(email) || string.IsNullOrEmpty(taxId))
                    {
                        MessageBox.Show("Деякі поля порожні. Неможливо відкрити вікно редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    User editUser = new User
                    {
                        Name = name,
                        PhoneNumber = phoneNumber,
                        Email = email,
                        TaxId = taxId,
                    };

                    Modify modify = new Modify(editUser);
                    modify.ShowDialog();
                    modify.Dispose();
                }

            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            NewUserAdding NewUserAddingPage = new NewUserAdding();

            NewUserAddingPage.ShowDialog();

            NewUserAddingPage.Dispose();    
        }
        public void AddRow(User user)
        {
            dataGridView1.Rows.Add(user.Name, user.PhoneNumber, user.Email, user.TaxId,user.Created, user.Updated);
        }
        public void AddRows(User[] user)
        {
            foreach(User item in user)
            {
                dataGridView1.Rows.Add(item.Name, item.PhoneNumber, item.Email, item.TaxId, item.Created, item.Updated);
            }
        }

        private void UsersTable_Load(object sender, EventArgs e)
        {
            client = new Service1Client();
            RefreshDataGrid();
        }
        public async void RefreshDataGrid()
        {
            try
            {
                var users = await client.GettingAllUsersAsync();
                dataGridView1.RowTemplate.Height = 40;
                foreach (var user in users)
                {
                    dataGridView1.Rows.Add(user.Name, user.PhoneNumber, user.Email, user.TaxId, user.Created, user.Updated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
        public void UpdateUser(User OldData, User NewData)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["SRNP"].Value.ToString() == OldData.TaxId
                    && row.Cells["email"].Value.ToString() == OldData.Email
                    && row.Cells["NS"].Value.ToString() == OldData.Name
                    && row.Cells["PN"].Value.ToString() == OldData.PhoneNumber)
                {
                    row.Cells["NS"].Value = NewData.Name;
                    row.Cells["PN"].Value = NewData.PhoneNumber;
                    row.Cells["email"].Value = NewData.Email;
                    row.Cells["SRNP"].Value = NewData.TaxId;
                    row.Cells["LTCD"].Value = NewData.Updated;
                }
            }
            client.ChargingSomeChanges(OldData, NewData);
            Update();
        }

        public User[] GettingAllUsers()
        {
            throw new NotImplementedException();
        }

        Task<User[]> IService1.GettingAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public void ChargingSomeChanges(User oldUser, User newUser)
        {
            throw new NotImplementedException();
        }

        public Task ChargingSomeChangesAsync(User oldUser, User newUser)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User User)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(User User)
        {
            throw new NotImplementedException();
        }

        public Task<User[]> GettingAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public WorkingService.UserOperationResult AddingNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<WorkingService.UserOperationResult> AddingNewUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
