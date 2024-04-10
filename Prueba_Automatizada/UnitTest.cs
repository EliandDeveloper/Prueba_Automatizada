using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Prueba_Automatizada.Pages;

namespace Prueba_Automatizada
{
    public class Tests
    {
        private IWebDriver driver;


        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();

            // Navegando hacia la web a la que aplicaremos las pruebas

            driver.Navigate().GoToUrl("http://localhost:5227");

            // Espera 5 segundos para dejar a la pagina cargar

            Thread.Sleep(TimeSpan.FromSeconds(5));

           

        }

        [Test]
        public void LoginTest()
        {


            Login Loginpage = new Login(driver);

            // Iniciar Sesion

            Loginpage.SignIn("elian", "1234");

            //Cerramos de la prueba

            driver.Quit();


        }

        [Test]
        public void AbogadoTest()
        {



            //Instancias de las clases a usar

            Login Loginpage = new Login(driver);

            Abogados Abogados = new Abogados(driver); 

            // Iniciar Sesion

            Loginpage.SignIn_and_Stay("elian", "1234","Abogados");

            // Registramos al abogado

            Abogados.AbogadoSave("Juan", "3333");

            //Cerramos de la prueba

            driver.Quit();


        }


        [Test]
        public void ClienteTest()
        {


            //Instancias de las clases a usar

            Login Loginpage = new Login(driver);

            Clientes clientes = new Clientes(driver);

            // Iniciar Sesion

            Loginpage.SignIn_and_Stay("elian", "1234", "Clientes");

            // Registramos al abogado

            clientes.ClienteSave("Juan", "Santos", "juan@gamil.com", 809434323, 829434323, "Las Americas", "Soltero");

            //Cerramos de la prueba

            driver.Quit();


        }

        [Test]
        public void CasoTest()
        {


            //Instancias de las clases a usar

            Login Loginpage = new Login(driver);

            Casos clientes = new Casos(driver);

            // Iniciar Sesion

            Loginpage.SignIn_and_Stay("elian", "1234", "Casos");

            // Registramos al abogado

            clientes.CasoSave("Juan", "elian", "Nuevo", "Las Americas", "Asesinato");

            //Cerramos de la prueba

            driver.Quit();


        }

        [Test]
        public void ImprimirTest()
        {


            //Instancias de las clases a usar

            Login Loginpage = new Login(driver);

            Imprimir clientes = new Imprimir(driver);

            // Iniciar Sesion

            Loginpage.SignIn_and_Stay("elian", "1234", "Imprimir");

            // Registramos al abogado

            clientes.ImprimirDetalles();

            //Cerramos de la prueba

            driver.Quit();


        }

    }

}