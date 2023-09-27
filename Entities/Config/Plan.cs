namespace Entities.Config
{
    /// <summary>
    /// Plan de estudio
    /// </summary>
    public class Plan : Entity
    {
        #region Attributes
        /// <summary>
        /// Valor del plan
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Valor de la cuota inicial
        /// </summary>
        public decimal InitialFee { get; set; }

        /// <summary>
        /// Número de cuotas
        /// </summary>
        public short InstallmentsNumber { get; set; }

        /// <summary>
        /// Valor de la cuota mensual
        /// </summary>
        public decimal InstallmentValue { get; set; }

        /// <summary>
        /// Si el plan está o no activo
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Descripción
        /// </summary>
        public string Description { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un plan con valores por defecto
        /// </summary>
        public Plan() : base()
        {
            Value = 0;
            InitialFee = 0;
            InstallmentsNumber = 0;
            InstallmentValue = 0;
            Active = false;
            Description = string.Empty;
        }
        #endregion
    }
}
