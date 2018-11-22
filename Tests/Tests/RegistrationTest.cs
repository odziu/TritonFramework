using NUnit.Framework;

namespace Tests.Tests
{
    public class RegistrationTest : BasicTest
    {
        [Test]
        [Description("Test verifies that user can create an account and login in it")]
        public void NewAccountCreationTest()
        {
            var page = mainPage
                .GoToLoginPage()
                .GoToRegistrationPage();

            Assert.AreEqual(page.PageTitle.Text, "Регистрация");
            
                page.SignUp();

            var accountPage = header.GoToAccountPage()
                .LogOut()
                .GoToLoginPage()
                .LogInRandomAccount();

            Assert.AreEqual(accountPage.PageTitle.Text, "Личный кабинет");
        }

    }
}
