using Entities.Auth;

namespace Entities.Test.Auth
{
    /// <summary>
    /// Pruebas de creaci�n de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creaci�n de un usuario
        /// </summary>
        [Fact]
        public void CreateUser()
        {
            Assert.IsType<User>(new User());
        }

        /// <summary>
        /// Prueba la creaci�n de un rol
        /// </summary>
        [Fact]
        public void CreateRole()
        {
            Assert.IsType<Role>(new Role());
        }

        /// <summary>
        /// Prueba la creaci�n de una aplicaci�n
        /// </summary>
        [Fact]
        public void CreateApplication()
        {
            Assert.IsType<Application>(new Application());
        }
    }
}