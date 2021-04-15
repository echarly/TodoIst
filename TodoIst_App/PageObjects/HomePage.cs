using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoIst_App.PageObjects
{
    public class HomePage : BasePage
    {

        By TodayTitle = By.XPath("//div[@class='view_header__content']//h1/span");
        By AddTaskButton = By.XPath("//button[@class='plus_add_button']");

        By TaskName = By.XPath("//div[@role='textbox']");
        By AddTaskText = By.XPath("//button[@type='submit']");
        By CancelTaskButton = By.XPath("//button[@class='cancel']");

        public HomePage clickAddTask()
        {

            Click(AddTaskButton);

            return this;
        }

        public HomePage EnterTaskName(string taskName)
        {

            EnterText(TaskName, taskName);
            Click(AddTaskText);

            return this;
        }

    }
}