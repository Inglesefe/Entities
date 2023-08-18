namespace Entities.Noti
{
    /// <summary>
    /// Plantilla de correo
    /// </summary>
    public class Template : EntityBase
    {
        #region Attributes
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
        public Template() : base()
        {
            Name = string.Empty;
            Content = string.Empty;
        }
        #endregion
    }
}
