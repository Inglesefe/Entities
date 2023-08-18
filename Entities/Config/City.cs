namespace Entities.Config
{
    /// <summary>
    /// Ciudad en el que tiene base la empresa
    /// </summary>
    public class City : EntityBase
    {
        #region Attributes
        /// <summary>
        /// País al que pertenece la ciudad
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Nombre de la ciudad
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Código de la ciudad
        /// </summary>
        public string Code { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una ciudad con valores por defecto
        /// </summary>
        public City() : base()
        {
            Country = new();
            Name = string.Empty;
            Code = string.Empty;
        }
        #endregion
    }
}
