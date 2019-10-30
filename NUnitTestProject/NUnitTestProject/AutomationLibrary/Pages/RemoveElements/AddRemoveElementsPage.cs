using NUnitTestProject.Pages;
using OpenQA.Selenium;

namespace NUnitTestProject.AutomationLibrary.Pages.RemoveElements
{
    public class AddRemoveElementsPage : BasePage
    {
        private const string AddRemoveElementsUrl = "https://the-internet.herokuapp.com/add_remove_elements/";

        public AddRemoveElementsPage(IWebDriver driver) : base(driver)
        {
            driver.Url = AddRemoveElementsUrl;
        }

        public AddRemoveElementsPage ClickAddElement()
        {
            Click(By.XPath("//button[text()='Add Element']"));
            return this;
        }

        public AddRemoveElementsPage ClickDeleteElement()
        {
            Click(By.XPath("//button[@class='added-manually']"));
            return this;
        }

        public AddRemoveElementsPage CheckDeletedButtonsCount(out int deletedButtonsCount)
        {
            deletedButtonsCount = driver.FindElements(By.ClassName("added-manually")).Count;
            return this;
        }

    }
}
