namespace Entities.Config
{
    /// <summary>
    /// País en el que tiene base la empresa
    /// </summary>
    public class Country : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del país
        /// </summary>
        public int Id { get; set; }
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
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
        #endregion
    }
}
