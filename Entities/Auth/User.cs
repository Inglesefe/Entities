namespace Entities.Auth
{
    /// <summary>
    /// Usuario que se conecta a la aplicación
    /// </summary>
    public class User : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del usuario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Login de acceso a la aplicación, de preferencia un correo electrónico
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Si el usuario está o no activo
        /// </summary>
        public bool Active { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un usuario con valores por defecto
        /// </summary>
        public User()
        {
            Id = 0;
            Login = string.Empty;
            Name = string.Empty;
            Active = false;
        }
        #endregion
    }
}