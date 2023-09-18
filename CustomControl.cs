using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebTesting
{
    public class CustomControl : DriverHelper
    {

        public static void ComboBox(string controlName, string value)
        {

            IWebElement comboBox = Driver.FindElement(By.XPath($"{controlName}-awed']"));
            comboBox.Clear();
            comboBox.SendKeys(value);
            Driver.FindElement(By.XPath($"{controlName}-dropmenu']//li[text()={value}]")).Click();
        }
    }
}
