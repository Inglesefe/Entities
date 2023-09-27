namespace Entities.Log
{
    /// <summary>
    /// Registra una acción sobre la base de datos (I-Insertar, U-Actualizar o D-Eliminar)
    /// </summary>
    public class LogDb : Entity
    {
        #region Attributes
        /// <summary>
        /// Fecha del registro
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Acción realizada sobre la tabla
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Identificador del registro en la tabla sobre la que se realizó la acción
        /// </summary>
        public long IdTable { get; set; }

        /// <summary>
        /// Tabla sobre la que se realizó la acción
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// Sentencia sql que se realizó
        /// </summary>
        public string Sql { get; set; }

        /// <summary>
        /// Identificador del usuario que realizó la acción,
        /// si no hay uno específico se le asigna el 1 (Usuario principal del sistema)
        /// </summary>
        public int User { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un registro de acción sobre la base de datos con valores por defecto
        /// </summary>
        public LogDb() : base()
        {
            Date = DateTime.Now;
            Action = string.Empty;
            IdTable = 0;
            Table = string.Empty;
            Sql = string.Empty;
            User = 0;
        }
        #endregion
    }
}
