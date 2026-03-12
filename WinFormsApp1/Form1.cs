using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ClientManager clientManager;

        public Form1()
        {
            InitializeComponent();
            clientManager = new ClientManager();
            UpdateClientsList();
        }

        private void UpdateClientsList()
        {
            clientsListBox.Items.Clear();
            foreach (var client in clientManager.Clients)
            {
                clientsListBox.Items.Add($"{client.Name} - {client.Email} ({client.Phone})");
            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox == null || emailTextBox == null ||
                    phoneTextBox == null || addressTextBox == null)
                {
                    MessageBox.Show("Ошибка инициализации полей ввода!",
                        "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Введите имя клиента!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(emailTextBox.Text))
                {
                    MessageBox.Show("Введите email клиента!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
                {
                    MessageBox.Show("Введите телефон клиента!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phoneTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(addressTextBox.Text))
                {
                    MessageBox.Show("Введите адрес клиента!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addressTextBox.Focus();
                    return;
                }

                string email = emailTextBox.Text.Trim();
                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Введите корректный email!\nПример: name@domain.com",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTextBox.Focus();
                    return;
                }

                string phone = phoneTextBox.Text.Trim();

                string cleanedPhone = phone.Replace(" ", "")      
                                           .Replace("-", "")      
                                           .Replace("(", "")    
                                           .Replace(")", "")      
                                           .Replace("+", "");    


                foreach (char c in cleanedPhone)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Телефон должен содержать только цифры!\n" +
                                      "Допустимые символы: пробел, дефис, скобки, +",
                                      "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        phoneTextBox.Focus();
                        return;
                    }
                }

                if (cleanedPhone.Length != 11)
                {
                    MessageBox.Show("Телефон должен содержать ровно 11 цифр!\n" +
                                  "Примеры правильных форматов:\n" +
                                  "89991234567\n" +
                                  "8-999-123-45-67\n" +
                                  "+7 (999) 123-45-67",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phoneTextBox.Focus();
                    return;
                }

                if (cleanedPhone[0] != '8' && cleanedPhone[0] != '7')
                {
                    MessageBox.Show("Российский номер должен начинаться с 8 или 7!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phoneTextBox.Focus();
                    return;
                }

                Client newClient = new Client(
                    nameTextBox.Text.Trim(),           
                    emailTextBox.Text.Trim(),          
                    cleanedPhone,                      
                    addressTextBox.Text.Trim()         
                );

                clientManager.AddClient(newClient);

                nameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
                addressTextBox.Clear();

                UpdateClientsList();

                MessageBox.Show($"Клиент {newClient.Name} успешно добавлен!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nameTextBox.Focus();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Ошибка: не переданы данные клиента\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка при сохранении в файл:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неожиданная ошибка:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveClientButton_Click(object sender, EventArgs e)
        {
            if (clientsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите клиента для удаления!");
                return;
            }

            string selectedItem = clientsListBox.SelectedItem.ToString();
            string[] parts = selectedItem.Split(new[] { '-' }, StringSplitOptions.None);
            if (parts.Length >= 2)
            {
                string name = parts[0].Trim();
                string email = parts[1].Trim();

                if (email.Contains("("))
                {
                    email = email.Substring(0, email.IndexOf("(")).Trim();
                }

                var clientToRemove = clientManager.Clients.Find(c => c.Name == name && c.Email == email);
                if (clientToRemove != null)
                {
                    try
                    {
                        clientManager.RemoveClient(clientToRemove);
                        UpdateClientsList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private bool IsValidPhone(string phone)
        {
            string cleanedPhone = phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");

            if (!Regex.IsMatch(cleanedPhone, @"^\d+$"))
            {
                MessageBox.Show("Телефон должен содержать только цифры!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cleanedPhone.Length != 11)
            {
                MessageBox.Show("Телефон должен содержать ровно 11 цифр!\nНапример: 89991234567",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string FormatPhone(string phone)
        {
            if (phone.Length == 11)
            {
                return $"{phone[0]}-{phone.Substring(1, 3)}-{phone.Substring(4, 3)}-{phone.Substring(7, 2)}-{phone.Substring(9, 2)}";
            }
            return phone;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                UpdateClientsList();
                return;
            }

            var searchResults = clientManager.SearchClients(searchTextBox.Text);
            clientsListBox.Items.Clear();
            foreach (var client in searchResults)
            {
                clientsListBox.Items.Add($"{client.Name} - {client.Email} ({client.Phone})");
            }
        }
    }
}