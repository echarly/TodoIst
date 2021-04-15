using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoIst_App;
using TodoIst_App.PageObjects;

namespace TodoIst_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void TestInitialize()
        {
            BasePage basePage = new BasePage();
            basePage.InitializeDriver();
        }

        [TestMethod]
        public void TestMethod1()
        {
            LoginPage login = new LoginPage();
            HomePage home = new HomePage();

            login
                .OpenBrowser()
                .UserLogin("charlyh@gmail.com", "nachas13");
            
            home
                .clickAddTask()
                .EnterTaskName("TaskName1")
                .EnterTaskName("TaskName2")
                .EnterTaskName("TaskName3");

        }

        [TestCleanup]
        public void CloseBrower()
        {
            BasePage basePage = new BasePage();
            basePage.closeBrowser();
        }
    }
}