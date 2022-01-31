using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.DevTools.V85.Debugger;

namespace ProjetoDemogoLivrariaQA
{
    public class UnitTest1
    {
        

        [Fact]
        public void Test1()
        {
            //arrange - dado que um navegador está aberto
            IWebDriver driver = new ChromeDriver(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));


            //act - quando navego para a URL https://demoqa.com/books
            driver.Navigate().GoToUrl("https://demoqa.com/books");


            //assert - então espero que espero que a página apresentadad seja da Demoga
            Assert.Contains("ToolsQA", driver.Title);
        }

   
    }
}