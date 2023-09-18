using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebTesting
{
    public class Tests : DriverHelper
    {
   
        [SetUp]
        
        public void Setup()
        {
             Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            Driver.FindElement(By.XPath("//*[@id=\"maincont\"]/div[1]/div[5]/div[2]/div[2]/div/ul/li[1]/label/div[1]/div/div")).Click();
            
            var control = new CustomControl();
            CustomControl.ComboBox("ContentPlaceHolder1_MealsCombo", "Almonds");


        }
    }
}