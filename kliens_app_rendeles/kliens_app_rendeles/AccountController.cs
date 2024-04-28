using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace kliens_app_rendeles
{
    public class AccountController
    {
        public bool ValidatePassword(string password)
        {
            // Legalább 3 karakter
            if (password.Length < 3) return false;

            // Csak angol ABC betűk és számok
            if (Regex.IsMatch(password, "^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)[A-Za-z\\d]{4,}$")) return true;

            // Ha minden feltétel teljesül, akkor érvényes a felhasználónév
            return false;
        }
        public bool ValidateEmail(string email)
        {
            // Egyszerű email validáció reguláris kifejezéssel
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public bool ValidateUsername(string username)
        {
            // Felhasználónév legalább 3 karakter hosszú legyen
            if (username.Length < 3) return false;

            // Csak angol ABC betűk és számok
            if (Regex.IsMatch(username, "^[a-zA-Z]+$")) return true;

            // Ha minden feltétel teljesül, akkor érvényes a felhasználónév
            return false;
        }
    }
}
