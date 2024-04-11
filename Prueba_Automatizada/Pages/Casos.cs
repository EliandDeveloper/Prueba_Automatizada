

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace Prueba_Automatizada.Pages
{
    public class Casos
    {

        private readonly IWebDriver driver;

        public Casos(IWebDriver driver)
        {
            this.driver = driver;
        }


        IWebElement caso_register => driver.FindElement(By.Id("casos_registrados"));

        IWebElement create_caso => driver.FindElement(By.Id("registrar_casos"));

        IWebElement input_tipo_caso => driver.FindElement(By.Id("civil"));

        IWebElement input_ubicacion => driver.FindElement(By.Id("ubicacion"));

        IWebElement input_descripcion => driver.FindElement(By.Id("descripcion"));

        IWebElement input_estado => driver.FindElement(By.Id("abierto"));

        IWebElement save_caso => driver.FindElement(By.Id("guardar_caso"));

        IWebElement exit_button => driver.FindElement(By.Id("salir"));

        public void CasoSave( string nombre,string encargado, string estado, string ubicacion, string descripcion)
        {


            Capturas.TakeScreenshot(driver, "Apartado de casos", "Casos");

            create_caso.Click();

            Capturas.TakeScreenshot(driver, "Formulario de registro de casos", "Casos");

            // Seleccion cliente valor

            IWebElement input_cliente_caso = driver.FindElement(By.Id("cliente_caso"));

            SelectElement cliente = new SelectElement(input_cliente_caso);

            cliente.SelectByText(nombre);

            // Seleccion caso valor

            input_tipo_caso.Click();

            // ubicacion y descripcion

            input_ubicacion.SendKeys(ubicacion);

            input_descripcion.SendKeys(descripcion);


            // Seleccion abogado valor

            IWebElement input_abogado_encargado = driver.FindElement(By.Id("abogado_encargado"));

            SelectElement abogado = new SelectElement(input_abogado_encargado);

            abogado.SelectByText(encargado);


            // seleccionar estado

            input_estado.Click();


            Capturas.TakeScreenshot(driver, "Datos_Ingresada_Correctamente", "Casos");

            // Hacemos que sea visible el boton de guardado, para que no de error

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", save_caso);

            Thread.Sleep(TimeSpan.FromSeconds(1));

            save_caso.Click();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            caso_register.Click();

            Capturas.TakeScreenshot(driver, "Visualizar caso nuevo", "Casos");

            exit_button.Click();

            Capturas.TakeScreenshot(driver, "Salida con el boton de salir", "Casos");


        }

    }
}
