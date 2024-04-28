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
        AccountController ac = new AccountController();
        public Bejelentkezes()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ac.ValidateUsername(usernameTextBox.Text)&& ac.ValidateEmail(emailTextBox.Text) && ac.ValidatePassword(passwordTextBox.Text))
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hibás adatok!");
            }

            


        }


    
    }

        
    }


