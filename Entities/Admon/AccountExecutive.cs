using Entities.Config;

namespace Entities.Admon
{
    /// <summary>
    /// Ejecutivo de cuenta
    /// </summary>
    public class AccountExecutive : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del ejecutivo de cuenta
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del ejecutivo de producción
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Número de identificación del ejecutivo
        /// </summary>
        public string Identification { get; set; }

        /// <summary>
        /// Tipo de identificación del ejecutivo
        /// </summary>
        public IdentificationType IdentificationType { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un titular con valores por defecto
        /// </summary>
        public AccountExecutive()
        {
            Id = 0;
            Name = string.Empty;
            Identification = string.Empty;
            IdentificationType = new();
        }
        #endregion
    }
}
