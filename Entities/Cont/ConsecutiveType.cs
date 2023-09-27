namespace Entities.Cont
{
    /// <summary>
    /// Tipo de consecutivo contable que se quiere controlar
    /// </summary>
    public class ConsecutiveType : Entity
    {
        #region Attributes
        /// <summary>
        /// Nombre del tipo de cuenta contable
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un tipo de cuenta con valores por defecto
        /// </summary>
        public ConsecutiveType() : base()
        {
            Name = string.Empty;
        }
        #endregion
    }
}
