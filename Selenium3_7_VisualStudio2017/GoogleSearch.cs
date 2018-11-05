using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using OpenQA.Selenium;

namespace Selenium3_7_VisualStudio2017
{
    [TestClass]
    public class NewUser
    {
        [TestMethod]
        public void Should_Search_Using_Firefox()
        {
            using (var driver = new FirefoxDriver())
            {
                // Some change
        
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://10.0.0.11/SocialDoc/Account/Login");

                var emailInput = driver.FindElementById("Email");

                emailInput.SendKeys("a@a.a");

                var emailPass = driver.FindElementById("Password");

                emailPass.SendKeys("a");

                var signIn = driver.FindElementById("btnSubmit");

                signIn.Click();

                driver.Navigate().GoToUrl("http://10.0.0.11/SocialDoc/SystemUser");

                Thread.Sleep(2000);

                var addUser = driver.FindElementById("btnAddSysUser");

                addUser.Click();

                var firstName = driver.FindElementById("FirstName");

                firstName.SendKeys("ooo");

                var lastName = driver.FindElementById("LastName");

                lastName.SendKeys("ooo");

                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[3]/input[1]")).SendKeys("ooo");

                Thread.Sleep(2000);

                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[4]/span[1]/span[1]/span[1]")).Click();

                Thread.Sleep(2000);

                driver.FindElement(By.XPath("/html[1]/body[1]/div[6]/div[1]/ul[1]/li[1]")).Click();

                Thread.Sleep(3000);

                var newPass = driver.FindElementById("Password");

                newPass.SendKeys("aaaaaa");

                var confirmPass = driver.FindElementById("PasswordConfirm");

                confirmPass.SendKeys("aaaaaa");

                var newEmail = driver.FindElementById("Email");

                newEmail.SendKeys("oooo@cccc.cccc");

                Thread.Sleep(2000);

                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/form[1]/div[2]/button[1]")).Click();

                Thread.Sleep(3000);

                driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/header[1]/span[1]")).Click();

                driver.Navigate().Refresh();

                driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[3]/span[1]")).Click();

                driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[3]/nav[1]/ul[1]/li[3]/a[1]")).Click();

                Thread.Sleep(5000);

                driver.Close();

            }
        }
    }
}
