using Entities.Admon;

namespace Entities.Test.Admon
{
    /// <summary>
    /// Pruebas de creaci�n de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creaci�n de un ejecutivo de producci�n
        /// </summary>
        [Fact]
        public void CreateAccountExecutive()
        {
            Assert.IsType<AccountExecutive>(new AccountExecutive());
        }

        /// <summary>
        /// Prueba la creaci�n de una matr�cula
        /// </summary>
        [Fact]
        public void CreateRegistration()
        {
            Assert.IsType<Registration>(new Registration());
        }

        /// <summary>
        /// Prueba la creaci�n de la relaci�n de una matr�cula, escala y ejecutivo de cuenta
        /// </summary>
        [Fact]
        public void CreateRegistrationScale()
        {
            Assert.IsType<RegistrationScale>(new RegistrationScale());
        }
    }
}