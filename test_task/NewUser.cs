using System;
using System.Linq;
using System.Windows.Forms;
using test_task.WorkingService;

namespace test_task
{
    public partial class NewUserAdding : Form
    {
        private static UsersTable instance;
        public NewUserAdding()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\+?[1-9]\d{1,14}$");
        }

        private bool IsEmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsNameValid(string name)
        {
            return !string.IsNullOrEmpty(name) && name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool IsTaxIdValid(string taxId)
        {
            return taxId.All(char.IsDigit);
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string phoneNumber = textBox3.Text;
                string email = textBox4.Text;
                string taxId = textBox2.Text;

                if (!IsNameValid(name))
                {
                    MessageBox.Show("Некоректне ім'я Воно має містити лише літери та прогалини.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPhoneNumberValid(phoneNumber))
                {
                    MessageBox.Show("Неправильний номер телефону. Введіть правильний номер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsEmailValid(email))
                {
                    MessageBox.Show("Неправильна електронна пошта. Введіть правильну адресу електронної пошти.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsTaxIdValid(taxId))
                {
                    MessageBox.Show("Неправильний ідентифікаційний номер. Він має містити лише цифри.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User user = new User
                {
                    Name = name,
                    PhoneNumber = phoneNumber,
                    Email = email,
                    TaxId = taxId,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };

                UserOperationResult result = (UserOperationResult)UsersTable.client.AddingNewUser(user);
                if (result == UserOperationResult.Good)
                {
                    instance = UsersTable.ReturnInstance();
                    instance.AddRow(user);
                    Close(); // Закрываем форму, если пользователь успешно добавлен
                }
                else
                {
                    string errorMessage = result switch
                    {
                        UserOperationResult.NameExists => "Користувач із таким ім'ям вже існує.",
                        UserOperationResult.EmailExists => "Користувач із такою електронною поштою вже існує.",
                        UserOperationResult.TaxIdExists => "Користувач із таким ідентифікаційним номером вже існує.",
                        UserOperationResult.PhoneNumberExists => "Користувач із таким номером телефону вже існує.",
                        _ => "Сталася невідома помилка."
                    };
                    MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
