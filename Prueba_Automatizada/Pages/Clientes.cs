

using OpenQA.Selenium;

namespace Prueba_Automatizada.Pages
{
    public class Clientes
    {
        private readonly IWebDriver driver;

        public Clientes(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement cliente_register => driver.FindElement(By.Id("clientes_registrados_ir"));

        IWebElement create_cliente => driver.FindElement(By.Id("registrar_cliente"));

        IWebElement input_cliente_name => driver.FindElement(By.Id("nombre_cliente"));

        IWebElement input_cliente_lastname => driver.FindElement(By.Id("apellido_cliente"));

        IWebElement input_email => driver.FindElement(By.Id("correo_cliente"));

        IWebElement input_tel => driver.FindElement(By.Id("telefono_cliente"));

        IWebElement input_cel => driver.FindElement(By.Id("celular_cliente"));

        IWebElement input_address => driver.FindElement(By.Id("direccion_cliente"));

        IWebElement input_state => driver.FindElement(By.Id("estadocivil_cliente"));

        IWebElement save_cliente_button => driver.FindElement(By.Id("guardar_cliente"));

        IWebElement exit_button => driver.FindElement(By.Id("salir"));

        public void ClienteSave(string name, string lastname, string email, int tel, int cel, string address, string state)
        {

            cliente_register.Click();

            Capturas.TakeScreenshot(driver, "Apartado de abogados", "Clientes");

            create_cliente.Click();

            Capturas.TakeScreenshot(driver, "Formulario de registro", "Clientes");

            input_cliente_name.SendKeys(name);

            input_cliente_lastname.SendKeys(lastname);

            input_email.SendKeys(email);

            input_tel.SendKeys(tel.ToString());

            input_cel.SendKeys(cel.ToString());

            input_address.SendKeys(address);

            input_state.SendKeys(state);


            Capturas.TakeScreenshot(driver, "Datos_Ingresada_Correctamente", "Clientes");

            // Hacemos que sea visible el boton de guardado, para que no de error

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", save_cliente_button);

            Thread.Sleep(TimeSpan.FromSeconds(1));

            save_cliente_button.Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            cliente_register.Click();

            Capturas.TakeScreenshot(driver, "Visualizar cliente nuevo", "Clientes");

            exit_button.Click();

            Capturas.TakeScreenshot(driver, "Salida con el boton de salir", "Clientes");


        }

    }
}
