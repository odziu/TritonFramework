using NUnit.Framework;

namespace Tests.Tests
{
    public class LoginTest : BasicTest
    {
        [Test]
        public void FirstTest()
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
    }
}

