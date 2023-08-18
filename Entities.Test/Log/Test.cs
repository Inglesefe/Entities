using Entities.Log;

namespace Entities.Test.Log
{
    /// <summary>
    /// Pruebas de creaci�n de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creaci�n de un log de base de datos
        /// </summary>
        [Fact]
        public void CreateLogDb()
        {
            Assert.IsType<LogDb>(new LogDb());
        }

        /// <summary>
        /// Prueba la creaci�n de un log de componente
        /// </summary>
        [Fact]
        public void CreateLogComponent()
        {
            Assert.IsType<LogComponent>(new LogComponent());
        }
    }
}