namespace Entities.Config
{
    /// <summary>
    /// Tipo de identificación
    /// </summary>
    public class IdentificationType : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del tipo de identificación
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del tipo de identificación
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un plan con valores por defecto
        /// </summary>
        public IdentificationType()
        {
            Name = string.Empty;
        }
        #endregion
    }
}
