namespace Entities.Noti
{
    /// <summary>
    /// Plantilla de correo
    /// </summary>
    public class Template : Entity
    {
        #region Attributes
        /// <summary>
        /// Identificador único de la plantilla
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la plantilla
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contenido html de la plantilla
        /// </summary>
        public string Content { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una plantilla con valores por defecto
        /// </summary>
        public Template()
        {
            Id = 0;
            Name = string.Empty;
            Content = string.Empty;
        }
        #endregion
    }
}
