namespace Entities.Config
{
    /// <summary>
    /// País en el que tiene base la empresa
    /// </summary>
    public class Country : EntityBase
    {
        #region Attributes
        /// <summary>
        /// Código del país
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del país
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un país con valores por defecto
        /// </summary>
        public Country() : base()
        {
            Code = string.Empty;
            Name = string.Empty;
        }
        #endregion
    }
}
