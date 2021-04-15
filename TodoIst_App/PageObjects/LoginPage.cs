using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoIst_App.PageObjects
{
    public class LoginPage : BasePage
    {
        string url = "http://todoist.com/app/";

        By UserEmail = By.Id("email");
        By Password = By.Id("password");
        By LoginButton = By.XPath("//form[@id='login_form']//button");

        //Page Title
        By PageTitle = By.XPath("//div[@class='login_signup_form content']//h1");

        public LoginPage OpenBrowser()
        {
            driver.Url = url;

            return this;
        }

        public LoginPage UserLogin(string userEmail, string password)
        {
            Console.WriteLine("Entering Username : " +userEmail);
            Console.WriteLine("Entering password : " + password);

            EnterText(UserEmail, userEmail);
            EnterText(Password, password);

            Click(LoginButton);

            return this;
        }
    }
}