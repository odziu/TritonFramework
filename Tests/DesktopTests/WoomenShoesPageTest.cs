using NUnit.Framework;

namespace Tests.DesktopTests
{
    public class WoomenShoesPageTest : BasicDesktopTest
    {
        [Test]
        [Description("Test verifies that Woomen Shoes Page is loaded")]
        public void CheckWoomenShoesPageTest()
        {
            var pageTitle = mainPage
                .GoToLoginPage()
                .LogIn();
            
            header.GoToWoomenShoesPage();
            
            Assert.IsTrue(pageTitle.PageTitle.Displayed);
            Assert.AreEqual(pageTitle.PageTitle.Text, "Женская обувь");
        }
    }
}
