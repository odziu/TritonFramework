using NUnit.Framework;

namespace Tests.DesktopTests
{
    public class MenShoesPageTest : BasicDesktopTest
    {
        [Test]
        [Description("Test verifies that Men Shoes Page is loaded")]
        public void CheckMenShoesPageTest()
        {
            var pageTitle = mainPage
                .GoToLoginPage()
                .LogIn();
            
            header.GoToMenShoesPage();

            Assert.IsTrue(pageTitle.PageTitle.Displayed);
            Assert.AreEqual(pageTitle.PageTitle.Text, "Мужская обувь");
        }
    }
}
