namespace Entities.Config
{
    /// <summary>
    /// Tipo de ingreso
    /// </summary>
    public class IncomeType : Entity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del tipo de ingreso
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Código del tipo de ingreso
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un plan con valores por defecto
        /// </summary>
        public IncomeType()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
        #endregion
    }
}
