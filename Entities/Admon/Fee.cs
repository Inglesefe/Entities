using Entities.Config;

namespace Entities.Admon
{
    /// <summary>
    /// Cuotas de la matricula según el plan seleccionado
    /// </summary>
    public class Fee : Entity
    {
        #region Attributes
        /// <summary>
        /// Identificador único de la cuota
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Matrícula a la que pertenece la cuota
        /// </summary>
        public Registration Registration { get; set; }

        /// <summary>
        /// Valor de la cuota
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Número de cuota
        /// </summary>
        public short Number { get; set; }

        /// <summary>
        /// Tipo de cuota
        /// </summary>
        public IncomeType IncomeType { get; set; }

        /// <summary>
        /// Fecha de vencimiento de la cuota
        /// </summary>
        public DateTime DueDate { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una cuota con valores por defecto
        /// </summary>
        public Fee()
        {
            Id = 0;
            Registration = new();
            Value = 0;
            Number = 0;
            IncomeType = new();
            DueDate = DateTime.Now;
        }
        #endregion
    }
}
