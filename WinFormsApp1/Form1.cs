using System;
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
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text)
            || string.IsNullOrEmpty(phoneTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            Client newClient = new Client(nameTextBox.Text, emailTextBox.Text,
            phoneTextBox.Text, addressTextBox.Text);

            try
            {
                clientManager.AddClient(newClient);
                nameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
                addressTextBox.Clear();
                UpdateClientsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                // Исправлено: убираем скобки из email
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