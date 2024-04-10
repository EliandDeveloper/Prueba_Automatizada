

using OpenQA.Selenium;

namespace Prueba_Automatizada.Pages
{
    public class Imprimir
    {
        private readonly IWebDriver driver;

        public Imprimir(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement navegar_impresion => driver.FindElement(By.Id("detalle_caso"));
        IWebElement imprimir_detalle => driver.FindElement(By.Id("imprimir_detalle_caso"));
        

        public void ImprimirDetalles()
        {

            navegar_impresion.Click();

            Capturas.TakeScreenshot(driver, "Apartado de detalles", "Imprimir");

            Thread.Sleep(TimeSpan.FromSeconds(1));

            imprimir_detalle.Click();

            Capturas.TakeScreenshot(driver, "Navegacion exitosa", "Imprimir");

        }

    }
}
