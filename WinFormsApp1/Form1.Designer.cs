namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private TextBox addressTextBox;
        private Button addClientButton;
        private Button removeClientButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private ListBox clientsListBox;
        private Label nameLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label addressLabel;
        private Label searchLabel;
        private GroupBox inputGroupBox;
        private GroupBox searchGroupBox;
        private GroupBox listGroupBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            addressTextBox = new TextBox();
            addClientButton = new Button();
            removeClientButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            clientsListBox = new ListBox();
            nameLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            addressLabel = new Label();
            searchLabel = new Label();
            inputGroupBox = new GroupBox();
            searchGroupBox = new GroupBox();
            listGroupBox = new GroupBox();
            inputGroupBox.SuspendLayout();
            searchGroupBox.SuspendLayout();
            listGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(86, 38);
            nameTextBox.Margin = new Padding(5, 6, 5, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Введите имя";
            nameTextBox.Size = new Size(254, 35);
            nameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(429, 38);
            emailTextBox.Margin = new Padding(5, 6, 5, 6);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Введите email";
            emailTextBox.Size = new Size(254, 35);
            emailTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(754, 38);
            phoneTextBox.Margin = new Padding(5, 6, 5, 6);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.PlaceholderText = "Телефон";
            phoneTextBox.Size = new Size(169, 35);
            phoneTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(86, 98);
            addressTextBox.Margin = new Padding(5, 6, 5, 6);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.PlaceholderText = "Введите адрес";
            addressTextBox.Size = new Size(837, 116);
            addressTextBox.TabIndex = 7;
            // 
            // addClientButton
            // 
            addClientButton.BackColor = Color.FromArgb(76, 175, 80);
            addClientButton.FlatAppearance.BorderSize = 0;
            addClientButton.FlatStyle = FlatStyle.Flat;
            addClientButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addClientButton.ForeColor = Color.White;
            addClientButton.Location = new Point(86, 230);
            addClientButton.Margin = new Padding(5, 6, 5, 6);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(171, 60);
            addClientButton.TabIndex = 8;
            addClientButton.Text = "➕ Добавить";
            addClientButton.UseVisualStyleBackColor = false;
            addClientButton.Click += AddClientButton_Click;
            // 
            // removeClientButton
            // 
            removeClientButton.BackColor = Color.FromArgb(244, 67, 54);
            removeClientButton.FlatAppearance.BorderSize = 0;
            removeClientButton.FlatStyle = FlatStyle.Flat;
            removeClientButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            removeClientButton.ForeColor = Color.White;
            removeClientButton.Location = new Point(274, 230);
            removeClientButton.Margin = new Padding(5, 6, 5, 6);
            removeClientButton.Name = "removeClientButton";
            removeClientButton.Size = new Size(171, 60);
            removeClientButton.TabIndex = 9;
            removeClientButton.Text = "✖ Удалить";
            removeClientButton.UseVisualStyleBackColor = false;
            removeClientButton.Click += RemoveClientButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(86, 38);
            searchTextBox.Margin = new Padding(5, 6, 5, 6);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Введите текст для поиска";
            searchTextBox.Size = new Size(340, 35);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(33, 150, 243);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(446, 36);
            searchButton.Margin = new Padding(5, 6, 5, 6);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(137, 50);
            searchButton.TabIndex = 2;
            searchButton.Text = "🔍 Искать";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // clientsListBox
            // 
            clientsListBox.BackColor = Color.FromArgb(245, 245, 245);
            clientsListBox.BorderStyle = BorderStyle.FixedSingle;
            clientsListBox.Font = new Font("Segoe UI", 9F);
            clientsListBox.HorizontalScrollbar = true;
            clientsListBox.ItemHeight = 30;
            clientsListBox.Location = new Point(10, 38);
            clientsListBox.Margin = new Padding(5, 6, 5, 6);
            clientsListBox.Name = "clientsListBox";
            clientsListBox.Size = new Size(938, 332);
            clientsListBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F);
            nameLabel.Location = new Point(10, 44);
            nameLabel.Margin = new Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(60, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Имя:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9F);
            emailLabel.Location = new Point(353, 44);
            emailLabel.Margin = new Padding(5, 0, 5, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(68, 30);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 9F);
            phoneLabel.Location = new Point(696, 44);
            phoneLabel.Margin = new Padding(5, 0, 5, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(56, 30);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Тел.:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 9F);
            addressLabel.Location = new Point(10, 104);
            addressLabel.Margin = new Padding(5, 0, 5, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(76, 30);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Адрес:";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 9F);
            searchLabel.Location = new Point(10, 44);
            searchLabel.Margin = new Padding(5, 0, 5, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(77, 30);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Поиск:";
            // 
            // inputGroupBox
            // 
            inputGroupBox.Controls.Add(nameLabel);
            inputGroupBox.Controls.Add(nameTextBox);
            inputGroupBox.Controls.Add(emailLabel);
            inputGroupBox.Controls.Add(emailTextBox);
            inputGroupBox.Controls.Add(phoneLabel);
            inputGroupBox.Controls.Add(phoneTextBox);
            inputGroupBox.Controls.Add(addressLabel);
            inputGroupBox.Controls.Add(addressTextBox);
            inputGroupBox.Controls.Add(addClientButton);
            inputGroupBox.Controls.Add(removeClientButton);
            inputGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            inputGroupBox.Location = new Point(21, 24);
            inputGroupBox.Margin = new Padding(5, 6, 5, 6);
            inputGroupBox.Name = "inputGroupBox";
            inputGroupBox.Padding = new Padding(5, 6, 5, 6);
            inputGroupBox.Size = new Size(960, 320);
            inputGroupBox.TabIndex = 0;
            inputGroupBox.TabStop = false;
            inputGroupBox.Text = "Ввод данных клиента";
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(searchLabel);
            searchGroupBox.Controls.Add(searchTextBox);
            searchGroupBox.Controls.Add(searchButton);
            searchGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchGroupBox.Location = new Point(21, 356);
            searchGroupBox.Margin = new Padding(5, 6, 5, 6);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Padding = new Padding(5, 6, 5, 6);
            searchGroupBox.Size = new Size(960, 120);
            searchGroupBox.TabIndex = 1;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Поиск клиентов";
            // 
            // listGroupBox
            // 
            listGroupBox.Controls.Add(clientsListBox);
            listGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listGroupBox.Location = new Point(21, 488);
            listGroupBox.Margin = new Padding(5, 6, 5, 6);
            listGroupBox.Name = "listGroupBox";
            listGroupBox.Padding = new Padding(5, 6, 5, 6);
            listGroupBox.Size = new Size(960, 430);
            listGroupBox.TabIndex = 2;
            listGroupBox.TabStop = false;
            listGroupBox.Text = "Список клиентов";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1001, 942);
            Controls.Add(inputGroupBox);
            Controls.Add(searchGroupBox);
            Controls.Add(listGroupBox);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление клиентами";
            inputGroupBox.ResumeLayout(false);
            inputGroupBox.PerformLayout();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            listGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}