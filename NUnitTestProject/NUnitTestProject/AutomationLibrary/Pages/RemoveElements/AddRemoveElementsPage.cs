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
            driver.FindElement(By.XPath("//button[text()='Add Element']"))
                .Click();
            return this;
        }

        public AddRemoveElementsPage ClickDeleteElement()
        {
            driver.FindElement(By.XPath("//button[@class='added-manually']"))
                .Click();
            return this;
        }

        public AddRemoveElementsPage CheckDeletedButtonsCount(out int deletedButtonsCount)
        {
            deletedButtonsCount = driver.FindElements(By.ClassName("added-manually")).Count;
            return this;
        }

    }
}
