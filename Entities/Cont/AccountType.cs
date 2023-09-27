namespace Entities.Cont
{
    /// <summary>
    /// Tipo de cuenta contable que se quiere registrar
    /// </summary>
    public class AccountType : Entity
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
        public AccountType() : base()
        {
            Name = string.Empty;
        }
        #endregion
    }
}
