
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Prueba_Automatizada.Pages
{
    public class Login
    {
        private readonly IWebDriver driver;

        public Login(IWebDriver driver) 
        {
            this.driver = driver;

        }

        IWebElement input_user => driver.FindElement(By.Id("user"));

        IWebElement input_password => driver.FindElement(By.Id("password"));

        IWebElement singIn_button => driver.FindElement(By.Id("confirm_button"));

        IWebElement singIn_button_stay => driver.FindElement(By.Id("confirm_button"));

        IWebElement exit_button => driver.FindElement(By.Id("salir"));


        public void SignIn(string user, string password) 
        {

            input_user.SendKeys(user);

            input_password.SendKeys(password);

            Capturas.TakeScreenshot(driver, "Datos_Ingresada_Correctamente", "Login");

            singIn_button.Click();

            Capturas.TakeScreenshot(driver, "Inicio_sesion_exitoso", "Login");

            exit_button.Click();

            Capturas.TakeScreenshot(driver, "Salida con el boton de salir", "Login");

        }

        public void SignIn_and_Stay(string user, string password, string folder)
        {

            input_user.SendKeys(user);

            input_password.SendKeys(password);

            Capturas.TakeScreenshot(driver, "Datos_Ingresada_Correctamente", folder);

            Thread.Sleep(TimeSpan.FromSeconds(1));

            singIn_button_stay.Click();

            Capturas.TakeScreenshot(driver, "Inicio_sesion_exitoso", folder);

        }
    }
}
