using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace kliens_app_rendeles
{
    public class AccountController
    {
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
        public bool ValidateEmail(string email)
        {
            // Egyszerű email validáció reguláris kifejezéssel
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public bool ValidateUsername(string username)
        {
            // Felhasználónév legalább 3 karakter hosszú legyen
            if (username.Length > 3) return false;

            // Csak angol ABC betűk és számok
            if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$")) return false;

            // Ha minden feltétel teljesül, akkor érvényes a felhasználónév
            return true;
        }
    }
}
