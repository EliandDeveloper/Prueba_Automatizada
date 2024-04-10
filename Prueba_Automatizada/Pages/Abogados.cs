

using OpenQA.Selenium;

namespace Prueba_Automatizada.Pages
{
    public class Abogados
    {
        private readonly IWebDriver driver;

        public Abogados(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement abogado_register => driver.FindElement(By.Id("abogados_registrados"));

        IWebElement create_abogado => driver.FindElement(By.Id("registrar_abogado"));

        IWebElement input_abogado_user => driver.FindElement(By.Id("abogado_user"));

        IWebElement input_abogado_password => driver.FindElement(By.Id("abogado_password"));

        IWebElement save_button => driver.FindElement(By.Id("abogado_guardar"));

        IWebElement exit_button => driver.FindElement(By.Id("salir"));


        public void AbogadoSave(string user, string password)
        {

            abogado_register.Click();

            Capturas.TakeScreenshot(driver, "Apartado de abogados", "Abogados");

            create_abogado.Click();

            Capturas.TakeScreenshot(driver, "Formulario de registro", "Abogados");

            input_abogado_user.SendKeys(user);

            input_abogado_password.SendKeys(password);

            Capturas.TakeScreenshot(driver, "Datos_Ingresada_Correctamente", "Abogados");

            save_button.Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            abogado_register.Click();

            Capturas.TakeScreenshot(driver, "Visualizar abogado nuevo", "Abogados");

            exit_button.Click();

            Capturas.TakeScreenshot(driver, "Salida con el boton de salir", "Abogados");


        }

    }
}
