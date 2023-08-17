namespace Entities.Log
{
    /// <summary>
    /// Registra una acción sobre un componente del sistema (I-Información o E-Error)
    /// </summary>
    public class LogComponent : EntityBase
    {
        #region Attributes
        /// <summary>
        /// Fecha del registro
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Componente sobre el que se realizó la acción
        /// </summary>
        public string Component { get; set; }

        /// <summary>
        /// Descripción de lo que se realizó
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Identificador del usuario que realizó la acción
        /// </summary>
        public int User { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un registro de acción sobre la base de datos con valores por defecto
        /// </summary>
        public LogComponent() : base()
        {
            Date = DateTime.Now;
            Type = string.Empty;
            Component = string.Empty;
            Description = string.Empty;
            User = 0;
        }
        #endregion
    }
}
