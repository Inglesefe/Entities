namespace Entities.Cont
{
    /// <summary>
    /// Tipo de cuenta contable que se quiere registrar
    /// </summary>
    public class AccountType : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del tipo de cuenta
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del tipo de cuenta contable
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un tipo de cuenta con valores por defecto
        /// </summary>
        public AccountType()
        {
            Id = 0;
            Name = string.Empty;
        }
        #endregion
    }
}
