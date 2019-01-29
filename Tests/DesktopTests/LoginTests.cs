using NUnit.Framework;

namespace Tests.DesktopTests
{
    public class LoginTests : BasicDesktopTest
    {
        [Test]
        [Description("Test verifies that user can login using valid credentials")]
        public void LoginWitValidCredentialsTest()
        {
            var accountPage = mainPage
                .GoToLoginPage()
                .LogIn();

            Assert.IsTrue(accountPage.SaveBtn.Displayed);
            Assert.AreEqual(accountPage.PageTitle.Text, "Личный кабинет");


            var ordersPage = accountPage
                .GoToOrdersPage();

            Assert.IsTrue(ordersPage.LogoutBtn.Displayed);
        }

        [Test]
        [Description("Test verifies that user can not login using invalid credentials")]
        public void LoginWithInvalidCredentialsTest()
        {
            var accountPage = mainPage
                .GoToLoginPage()
                .LogInWithInvalidCredentials();

            Assert.AreEqual(accountPage.HelpBlock.Text, "Некорректный логин или пароль.");
        }
    }
}

