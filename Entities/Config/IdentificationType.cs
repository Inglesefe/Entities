namespace Entities.Config
{
    /// <summary>
    /// Tipo de identificación
    /// </summary>
    public class IdentificationType : Entity
    {
        #region Attributes
        /// <summary>
        /// Nombre del tipo de identificación
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un plan con valores por defecto
        /// </summary>
        public IdentificationType() : base()
        {
            Name = string.Empty;
        }
        #endregion
    }
}
