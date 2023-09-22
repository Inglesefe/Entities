using Entities.Admon;
using Entities.Config;

namespace Entities.Cont
{
    /// <summary>
    /// Pago realizado a una cuota de una matrícula
    /// </summary>
    public class Payment : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del pago
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Cuota de una matrícula a la que pertenece el pago
        /// </summary>
        public Fee Fee { get; set; }

        /// <summary>
        /// Tipo de pago
        /// </summary>
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// Valor del pago
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Fecha del pago
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Factura correspondiente al pago
        /// </summary>
        public string Invoice { get; set; }

        /// <summary>
        /// Comprobante del pago
        /// </summary>
        public string Proof { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un pago con valores por defecto
        /// </summary>
        public Payment()
        {
            Id = 0;
            Fee = new();
            PaymentType = new();
            Value = 0;
            Date = DateTime.Now;
            Invoice = string.Empty;
            Proof = string.Empty;
        }
        #endregion
    }
}
