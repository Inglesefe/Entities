using Entities.Noti;

namespace Entities.Test.Noti
{
    /// <summary>
    /// Pruebas de creaci�n de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creaci�n de una plantilla
        /// </summary>
        [Fact]
        public void CreateTemplate()
        {
            Assert.IsType<Template>(new Template());
        }

        /// <summary>
        /// Prueba la creaci�n de una notificaci�n
        /// </summary>
        [Fact]
        public void CreateNotification()
        {
            Assert.IsType<Notification>(new Notification());
        }
    }
}