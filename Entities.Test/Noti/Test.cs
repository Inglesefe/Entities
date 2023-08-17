using Entities.Noti;

namespace Entities.Test.Noti
{
    /// <summary>
    /// Pruebas de creación de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creación de una plantilla
        /// </summary>
        [Fact]
        public void CreateTemplate()
        {
            Assert.IsType<Template>(new Template());
        }

        /// <summary>
        /// Prueba la creación de una notificación
        /// </summary>
        [Fact]
        public void CreateNotification()
        {
            Assert.IsType<Notification>(new Notification());
        }
    }
}