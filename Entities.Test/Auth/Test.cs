using Entities.Auth;

namespace Entities.Test.Auth
{
    /// <summary>
    /// Pruebas de creación de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creación de un usuario
        /// </summary>
        [Fact]
        public void CreateUser()
        {
            Assert.IsType<User>(new User());
        }

        /// <summary>
        /// Prueba la creación de un rol
        /// </summary>
        [Fact]
        public void CreateRole()
        {
            Assert.IsType<Role>(new Role());
        }

        /// <summary>
        /// Prueba la creación de una aplicación
        /// </summary>
        [Fact]
        public void CreateApplication()
        {
            Assert.IsType<Application>(new Application());
        }
    }
}