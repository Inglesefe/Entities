namespace Entities.Auth
{
    /// <summary>
    /// Rol al que pertenece un usuario dentro del sistema
    /// </summary>
    public class Role : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del rol
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del rol
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un rol con valores por defecto
        /// </summary>
        public Role()
        {
            Id = 0;
            Name = string.Empty;
        }
        #endregion
    }
}