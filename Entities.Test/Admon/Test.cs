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
    }
}