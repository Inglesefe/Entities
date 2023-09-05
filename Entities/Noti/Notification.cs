namespace Entities.Noti
{
    /// <summary>
    /// Notificación de correo
    /// </summary>
    public class Notification : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único de la notificación
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Fecha en que se hizo la notificación
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Dirección de correo a quien se envía la notificación
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Asunto de la notificación
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// ôntenido de la notificación
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Identificador del usuario que realizó la notificación
        /// </summary>
        public int User { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una notificación con valores por defecto
        /// </summary>
        public Notification()
        {
            Id = 0;
            Subject = string.Empty;
            To = string.Empty;
            Content = string.Empty;
            User = 0;
            Date = DateTime.Now;
        }
        #endregion
    }
}
