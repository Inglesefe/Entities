using Entities.Config;

namespace Entities.Cont
{
    /// <summary>
    /// Número de consecutivo contable ascociado a un tipo de consecutivo y a una ciudad
    /// </summary>
    public class ConsecutiveNumber : Entity
    {
        #region Attributes
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
        public ConsecutiveNumber() : base()
        {
            ConsecutiveType = new();
            City = new();
            Number = string.Empty;
        }
        #endregion
    }
}
