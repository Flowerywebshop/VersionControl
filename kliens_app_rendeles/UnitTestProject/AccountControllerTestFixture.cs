using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
namespace UnitTestProject
{
    public class AccountControllerTestFixture
    {
        [
        Test,
        TestCase("abcd1234", false),
        TestCase("irf@uni-corvinus", false),
        TestCase("irf.uni-corvinus.hu", false),
        TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test,
    TestCase("abcdefgH", false),  // nincs szám
    TestCase("12345678", false),  // nincs kisbetű
    TestCase("abcdefgh", false),  // nincs nagybetű
    TestCase("Abc1", false),      // túl rövid
    TestCase("Abcdefg1H", true)]  // megfelelő
        public void TestValidatePassword(string password, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidatePassword(password);

            // Assert

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
        [Test,
         TestCase("", false),            // Üres felhasználónév
         TestCase("a", false),           // Túl rövid
         TestCase("abc123", true),       // Érvényes
         TestCase("user!name", false),   // Tiltott karakter
         TestCase("thisisaverylongusername", true)] // Érvényes
        public void TestValidateUsername(string username, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateUsername(username);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
    public class AccountController
    {
        public bool ValidatePassword(string password)
        {
            // Legalább 8 karakter
            if (password.Length < 8) return false;

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
            if (username.Length < 3) return false;

            // Csak angol ABC betűk és számok
            if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$")) return false;

            // Ha minden feltétel teljesül, akkor érvényes a felhasználónév
            return true;
        }
    }
}
