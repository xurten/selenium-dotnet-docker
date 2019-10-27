using NUnit.Framework;
using NUnitTestProject.AutomationLibrary.Pages.RemoveElements;

namespace NUnitTestProject.Tests
{
    public class AddRemoveElementsTests : BaseTest
    {
        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(2, 1, 1)]
        [TestCase(3, 2, 1)]
        [TestCase(4, 0, 4)]
        public void CheckAddRemoveButtonTests(int clickAddCount, int clickDeleteCount, int expectedDeletedButtonsCount)
        {
            AddRemoveElementsPage page = new AddRemoveElementsPage(driver);
            for(int clickIndex = 0; clickIndex < clickAddCount; clickIndex++)
            {
                page.ClickAddElement();
            }

            for (int clickIndex = 0; clickIndex < clickDeleteCount; clickIndex++)
            {
                page.ClickDeleteElement();
            }

            page.CheckDeletedButtonsCount(out int deletedButtonsCount);
            Assert.AreEqual(expectedDeletedButtonsCount, deletedButtonsCount);
        }
    }
}
