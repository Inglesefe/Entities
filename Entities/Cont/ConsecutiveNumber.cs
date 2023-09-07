namespace Entities.Config
{
    /// <summary>
    /// Número de consecutivo contable ascociado a un tipo de consecutivo y a una ciudad
    /// </summary>
    public class ConsecutiveNumber : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del número de consecutivo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tipo de consecutivo contable
        /// </summary>
        public ConsecutiveType ConsecutiveType { get; set; }

        /// <summary>
        /// Ciudad asociada al consecutivo
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Número del consecutivo contable
        /// </summary>
        public string Number { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un número de consecutivo con valores por defecto
        /// </summary>
        public ConsecutiveNumber()
        {
            Id = 0;
            ConsecutiveType = new();
            City = new();
            Number = string.Empty;
        }
        #endregion
    }
}
