namespace Entities.Config
{
    /// <summary>
    /// Tipos de pago
    /// </summary>
    public class PaymentType : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del tipo de pago
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del tipo de pago
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un tipo de pago con valores por defecto
        /// </summary>
        public PaymentType()
        {
            Id = 0;
            Name = string.Empty;
        }
        #endregion
    }
}
