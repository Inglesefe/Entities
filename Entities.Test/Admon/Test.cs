using Entities.Admon;

namespace Entities.Test.Admon
{
    /// <summary>
    /// Pruebas de creación de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creación de un ejecutivo de producción
        /// </summary>
        [Fact]
        public void CreateAccountExecutive()
        {
            Assert.IsType<AccountExecutive>(new AccountExecutive());
        }

        /// <summary>
        /// Prueba la creación de una matrícula
        /// </summary>
        [Fact]
        public void CreateRegistration()
        {
            Assert.IsType<Registration>(new Registration());
        }

        /// <summary>
        /// Prueba la creación de la relación de una matrícula, escala y ejecutivo de cuenta
        /// </summary>
        [Fact]
        public void CreateRegistrationScale()
        {
            Assert.IsType<RegistrationScale>(new RegistrationScale());
        }
    }
}