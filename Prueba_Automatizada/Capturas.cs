using OpenQA.Selenium;


public static class Capturas
{
    public static void TakeScreenshot(IWebDriver driver, string capture_name, string folder)
    {
        
        Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
        
        string Basefolder = "C:/Users/MSI/OneDrive/Escritorio/Tareas 5to Cuatrimestre/Programación 3" +
                            "/Pruebas automatizadas/Prueba_Automatizada" +
                            "/Prueba_Automatizada/";
        
        //Ruta de guardado

        string path_screenshot = Path.Combine(Basefolder, folder);
  
        Directory.CreateDirectory(path_screenshot);
        
        string screenshotPath = Path.Combine(path_screenshot, $"{capture_name}.png");
        
        screenshot.SaveAsFile(screenshotPath);

    }
}
