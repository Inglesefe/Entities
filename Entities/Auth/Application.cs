namespace Entities.Auth
{
    /// <summary>
    /// Aplicación a la que puede ingresar un usuario,
    /// también puede representar un módulo de una aplicación más grande
    /// </summary>
    public class Application : Entity
    {
        #region Attributes
        /// <summary>
        /// Identificador único de la aplicación
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la aplicación
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una aplicación con valores por defecto
        /// </summary>
        public Application()
        {
            Id = 0;
            Name = string.Empty;
        }
        #endregion
    }
}