namespace Entities.Config
{
    /// <summary>
    /// Parámetro del sistema
    /// </summary>
    public class Parameter : Entity
    {
        #region Attributes
        /// <summary>
        /// Nombre del parámetro
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Valor del parámetro
        /// </summary>
        public string Value { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un consecutivo con valores por defecto
        /// </summary>
        public Parameter() : base()
        {
            Name = string.Empty;
            Value = string.Empty;
        }
        #endregion
    }
}
