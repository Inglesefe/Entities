using Entities.Config;

namespace Entities.Test.Cont
{
    /// <summary>
    /// Pruebas de creación de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creación de un número de cuenta
        /// </summary>
        [Fact]
        public void CreateAccountNumber()
        {
            Assert.IsType<AccountNumber>(new AccountNumber());
        }

        /// <summary>
        /// Prueba la creación de un tipo de cuenta
        /// </summary>
        [Fact]
        public void CreateAccountType()
        {
            Assert.IsType<AccountType>(new AccountType());
        }

        /// <summary>
        /// Prueba la creación de un número consecutivo
        /// </summary>
        [Fact]
        public void CreateConsecutiveNumber()
        {
            Assert.IsType<ConsecutiveNumber>(new ConsecutiveNumber());
        }

        /// <summary>
        /// Prueba la creación de un tipo de consecutivo
        /// </summary>
        [Fact]
        public void CreateConsecutiveType()
        {
            Assert.IsType<ConsecutiveType>(new ConsecutiveType());
        }
    }
}
