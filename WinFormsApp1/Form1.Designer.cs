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
            // Инициализация компонентов
            this.nameTextBox = new TextBox();
            this.emailTextBox = new TextBox();
            this.phoneTextBox = new TextBox();
            this.addressTextBox = new TextBox();
            this.addClientButton = new Button();
            this.removeClientButton = new Button();
            this.searchTextBox = new TextBox();
            this.searchButton = new Button();
            this.clientsListBox = new ListBox();
            this.nameLabel = new Label();
            this.emailLabel = new Label();
            this.phoneLabel = new Label();
            this.addressLabel = new Label();
            this.searchLabel = new Label();
            this.inputGroupBox = new GroupBox();
            this.searchGroupBox = new GroupBox();
            this.listGroupBox = new GroupBox();

            this.inputGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.SuspendLayout();

            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 22);
            this.nameLabel.Text = "Имя:";
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.nameTextBox.Location = new System.Drawing.Point(50, 19);
            this.nameTextBox.Size = new System.Drawing.Size(150, 23);
            this.nameTextBox.PlaceholderText = "Введите имя";

            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(206, 22);
            this.emailLabel.Text = "Email:";
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.emailTextBox.Location = new System.Drawing.Point(250, 19);
            this.emailTextBox.Size = new System.Drawing.Size(150, 23);
            this.emailTextBox.PlaceholderText = "Введите email";

            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(406, 22);
            this.phoneLabel.Text = "Тел.:";
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.phoneTextBox.Location = new System.Drawing.Point(440, 19);
            this.phoneTextBox.Size = new System.Drawing.Size(100, 23);
            this.phoneTextBox.PlaceholderText = "Телефон";

            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(6, 52);
            this.addressLabel.Text = "Адрес:";
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.addressTextBox.Location = new System.Drawing.Point(50, 49);
            this.addressTextBox.Size = new System.Drawing.Size(490, 60);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.PlaceholderText = "Введите адрес";

            this.addClientButton.Location = new System.Drawing.Point(50, 115);
            this.addClientButton.Size = new System.Drawing.Size(100, 30);
            this.addClientButton.Text = "➕ Добавить";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addClientButton.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.addClientButton.ForeColor = System.Drawing.Color.White;
            this.addClientButton.FlatStyle = FlatStyle.Flat;
            this.addClientButton.FlatAppearance.BorderSize = 0;

            this.removeClientButton.Location = new System.Drawing.Point(160, 115);
            this.removeClientButton.Size = new System.Drawing.Size(100, 30);
            this.removeClientButton.Text = "✖ Удалить";
            this.removeClientButton.UseVisualStyleBackColor = true;
            this.removeClientButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeClientButton.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.removeClientButton.ForeColor = System.Drawing.Color.White;
            this.removeClientButton.FlatStyle = FlatStyle.Flat;
            this.removeClientButton.FlatAppearance.BorderSize = 0;

            this.inputGroupBox.Controls.Add(this.nameLabel);
            this.inputGroupBox.Controls.Add(this.nameTextBox);
            this.inputGroupBox.Controls.Add(this.emailLabel);
            this.inputGroupBox.Controls.Add(this.emailTextBox);
            this.inputGroupBox.Controls.Add(this.phoneLabel);
            this.inputGroupBox.Controls.Add(this.phoneTextBox);
            this.inputGroupBox.Controls.Add(this.addressLabel);
            this.inputGroupBox.Controls.Add(this.addressTextBox);
            this.inputGroupBox.Controls.Add(this.addClientButton);
            this.inputGroupBox.Controls.Add(this.removeClientButton);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Size = new System.Drawing.Size(560, 160);
            this.inputGroupBox.Text = "Ввод данных клиента";
            this.inputGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);


            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(6, 22);
            this.searchLabel.Text = "Поиск:";
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

    
            this.searchTextBox.Location = new System.Drawing.Point(50, 19);
            this.searchTextBox.Size = new System.Drawing.Size(200, 23);
            this.searchTextBox.PlaceholderText = "Введите текст для поиска";

 
            this.searchButton.Location = new System.Drawing.Point(260, 18);
            this.searchButton.Size = new System.Drawing.Size(80, 25);
            this.searchButton.Text = "🔍 Искать";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.FlatStyle = FlatStyle.Flat;
            this.searchButton.FlatAppearance.BorderSize = 0;


            this.searchGroupBox.Controls.Add(this.searchLabel);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 178);
            this.searchGroupBox.Size = new System.Drawing.Size(560, 60);
            this.searchGroupBox.Text = "Поиск клиентов";
            this.searchGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.clientsListBox.Location = new System.Drawing.Point(6, 19);
            this.clientsListBox.Size = new System.Drawing.Size(548, 180);
            this.clientsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientsListBox.BorderStyle = BorderStyle.FixedSingle;
            this.clientsListBox.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.clientsListBox.HorizontalScrollbar = true;

   
            this.listGroupBox.Controls.Add(this.clientsListBox);
            this.listGroupBox.Location = new System.Drawing.Point(12, 244);
            this.listGroupBox.Size = new System.Drawing.Size(560, 215);
            this.listGroupBox.Text = "Список клиентов";
            this.listGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);


            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 471);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.listGroupBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Управление клиентами";
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.listGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}