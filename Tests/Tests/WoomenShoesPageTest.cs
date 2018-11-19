using NUnit.Framework;

namespace Tests.Tests
{
    public class WoomenShoesPageTest : BasicTest
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
