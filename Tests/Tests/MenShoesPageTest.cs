using NUnit.Framework;

namespace Tests.Tests
{
    public class MenShoesPageTest : BasicTest
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
