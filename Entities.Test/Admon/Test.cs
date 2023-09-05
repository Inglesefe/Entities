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
    }
}