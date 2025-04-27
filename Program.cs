using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo WebDriver
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Mở trang login
                driver.Navigate().GoToUrl("https://www.sport9.vn/login");

                // Tối ưu hóa cửa sổ trình duyệt
                driver.Manage().Window.Maximize();

                // Tìm ô nhập username và nhập giá trị
                IWebElement usernameField = driver.FindElement(By.Id("Email"));
                usernameField.SendKeys("your_username");

                // Tìm ô nhập password và nhập giá trị
                IWebElement passwordField = driver.FindElement(By.Id("Password"));
                passwordField.SendKeys("your_password");

                // Tìm nút đăng nhập và click
                IWebElement loginButton = driver.FindElement(By.CssSelector(".button-1.login-button"));
                loginButton.Click();

                // Đợi một chút cho trang load (chờ cứng, nên thay bằng wait tường minh nếu cần)
                Thread.Sleep(2000);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }
    }
    
}
