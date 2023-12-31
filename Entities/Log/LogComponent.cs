﻿namespace Entities.Log
{
    /// <summary>
    /// Registra una acción sobre un componente del sistema (I-Información o E-Error)
    /// </summary>
    public class LogComponent : Entity
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
        /// Controlador del API sobre el que se realizó la acción
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Método del controlador del API sobre el que se realizó la acción
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Datos de entrada del componente de lo que se realizó
        /// </summary>
        public string Input { get; set; }

        /// <summary>
        /// Datos de salida del componente de lo que se realizó
        /// </summary>
        public string Output { get; set; }

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
            Controller = string.Empty;
            Method = string.Empty;
            Input = string.Empty;
            Output = string.Empty;
            User = 0;
        }
        #endregion
    }
}
