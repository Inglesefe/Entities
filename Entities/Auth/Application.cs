namespace Entities.Auth
{
    /// <summary>
    /// Aplicación a la que puede ingresar un usuario,
    /// también puede representar un módulo de una aplicación más grande
    /// </summary>
    public class Application : EntityBase
    {
        #region Attributes
        /// <summary>
        /// Nombre de la aplicación
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una aplicación con valores por defecto
        /// </summary>
        public Application() : base()
        {
            Name = string.Empty;
        }
        #endregion
    }
}