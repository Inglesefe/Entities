namespace Entities.Auth
{
    /// <summary>
    /// Rol al que pertenece un usuario dentro del sistema
    /// </summary>
    public class Role : EntityBase
    {
        #region Attributes
        /// <summary>
        /// Nombre del rol
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un rol con valores por defecto
        /// </summary>
        public Role() : base()
        {
            Name = string.Empty;
        }
        #endregion
    }
}