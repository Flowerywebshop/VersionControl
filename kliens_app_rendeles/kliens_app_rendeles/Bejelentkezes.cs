using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace kliens_app_rendeles
{
    public partial class Bejelentkezes : Form
    {

        public Bejelentkezes()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == true)
            {
                DialogResult = DialogResult.OK;

            }

            Form2 form2 = new Form2();
            form2.ShowDialog();


        }


        private bool CheckName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(usernameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(usernameTextBox, "Nem lehet üres!");
            }
        }

        private void usernameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(usernameTextBox, string.Empty);
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");

            if (!regex.IsMatch(emailTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(emailTextBox, "Érvénytelen email cím. Kérjük, adja meg a helyes formátumot.");
            }
        }

        private void emailTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(emailTextBox, string.Empty);

        }

        public bool ValidatePassword(string password)
        {
            // Legalább 8 karakter
            if (password.Length > 8) return false;

            // Legalább egy kisbetű
            if (!Regex.IsMatch(password, "[a-z]")) return false;

            // Legalább egy nagybetű
            if (!Regex.IsMatch(password, "[A-Z]")) return false;

            // Legalább egy szám
            if (!Regex.IsMatch(password, "[0-9]")) return false;

            // Ha minden feltétel teljesül, akkor érvényes a jelszó
            return true;
        }


        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(passwordTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordTextBox, "Kell legalább egy nagybetű, egy kisbetű és egy szám, a jelszónak legalább 8 karakternek kell lennie");

            }

        }

        private void passwordTextBox_Validated(object sender, EventArgs e)
        {

            {
                errorProvider1.SetError(passwordTextBox, string.Empty);

            }
        }
    }
}

