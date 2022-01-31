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
            //arrange - dado que um navegador est� aberto
            IWebDriver driver = new ChromeDriver(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));


            //act - quando navego para a URL https://demoqa.com/books
            driver.Navigate().GoToUrl("https://demoqa.com/books");


            //assert - ent�o espero que espero que a p�gina apresentadad seja da Demoga
            Assert.Contains("ToolsQA", driver.Title);
        }

   
    }
}