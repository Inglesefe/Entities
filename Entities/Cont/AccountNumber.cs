namespace Entities.Config
{
    /// <summary>
    /// Número de cuenta contable ascociada a un tipo de cuenta y a una ciudad
    /// </summary>
    public class AccountNumber : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del número de cuenta
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tipo de cuenta contable
        /// </summary>
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Ciudad asociada a la cuenta
        /// </summary>
        public City City { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un número de cuenta con valores por defecto
        /// </summary>
        public AccountNumber()
        {
            Id = 0;
            AccountType = new();
            City = new();
        }
        #endregion
    }
}
