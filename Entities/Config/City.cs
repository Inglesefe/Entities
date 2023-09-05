namespace Entities.Config
{
    /// <summary>
    /// Ciudad en el que tiene base la empresa
    /// </summary>
    public class City : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único de la ciudad
        /// </summary>
        public int Id { get; set; }

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
        public City()
        {
            Id = 0;
            Country = new();
            Name = string.Empty;
            Code = string.Empty;
        }
        #endregion
    }
}
