using NUnit.Framework;

namespace Tests.Tests
{
    public class RegistrationTest : BasicTest
    {
        [Test]
        public void NewAccountCreationTest()
        {
            var page = mainPage
                .GoToLoginPage()
                .GoToRegistrationPage();

            Assert.AreEqual(page.PageTitle.Text, "Регистрация");
            
                page.SignUp();

            var accountPage = header.GoToAccountPage();

            Assert.IsTrue(accountPage.LogoutBtn.Displayed);
            Assert.AreEqual(accountPage.PageTitle.Text, "Личный кабинет");
        }

    }
}
