using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace projetoVitao
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(); // criando referencia o meu navegador

            driver.Navigate().GoToUrl("http://www.google.com.br"); // para navegar

            //IWebElement element = driver.FindElement(By.Name("q"));

            IWebElement element = driver.FindElement(By.CssSelector("input.gLFyf.gsfi"));
            //

            element.SendKeys("botafogo campeão");


            driver.Close();

        }

        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver(); // criando referencia o meu navegador

            driver.Navigate().GoToUrl("http://www.google.com.br"); // para navegar

            //IWebElement element = driver.FindElement(By.Name("q"));

            IWebElement element = driver.FindElement(By.CssSelector("input.gLFyf.gsfi"));
            //

            element.SendKeys("botafogo campeão");


            driver.Close();

        }

        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = new ChromeDriver(); // criando referencia o meu navegador

            driver.Navigate().GoToUrl("http://www.google.com.br"); // para navegar

            //IWebElement element = driver.FindElement(By.Name("q"));

            IWebElement element = driver.FindElement(By.CssSelector("input.gLFyf.gsfi"));
            //

            element.SendKeys("botafogo campeão");


            driver.Close();

        }

    }
}
