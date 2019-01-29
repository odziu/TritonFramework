using NUnit.Framework;

namespace Tests.MobileTests
{
    public class MobileLoginTests : BasicMobileTest
    {
        [Test]
        [Description("Test verifies that user can login using valid credentials")]
        public void FirstMobileTest()
        {
            var accountPage = mainPage
                .GoToLoginPage()
                .LogIn();

            Assert.IsTrue(accountPage.SaveBtn.Displayed);
            Assert.AreEqual(accountPage.PageTitle.Text, "Личный кабинет");
        }
    }
}
