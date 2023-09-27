namespace Entities.Config
{
    /// <summary>
    /// Tipos de pago
    /// </summary>
    public class PaymentType : Entity
    {
        #region Attributes
        /// <summary>
        /// Nombre del tipo de pago
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un tipo de pago con valores por defecto
        /// </summary>
        public PaymentType() : base()
        {
            Name = string.Empty;
        }
        #endregion
    }
}
