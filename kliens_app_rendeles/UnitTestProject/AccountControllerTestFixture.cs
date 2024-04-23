using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kliens_app_rendeles;
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
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test,
    TestCase("abcdefgH", false),  // nincs szám
    TestCase("12345678", false),  // nincs kisbetű
    TestCase("abcdefgh", false),  // nincs nagybetű
   ]
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
        
      
         TestCase("user!name", false),   // Tiltott karakter
         ]
        public void TestValidateUsername(string username, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateUsername(username);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
  
}
