using Entities.Config;

namespace Entities.Crm
{
    /// <summary>
    /// Beneficiario de la matrícula
    /// </summary>
    public class Beneficiary : Entity
    {
        #region Attributes
        /// <summary>
        /// Titular al que corresponde este beneficiario
        /// </summary>
        public Owner Owner { get; set; }

        /// <summary>
        /// Nombre del beneficiario
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Número de identificación del beneficiario
        /// </summary>
        public string Identification { get; set; }

        /// <summary>
        /// Tipo de identificación
        /// </summary>
        public IdentificationType IdentificationType { get; set; }

        /// <summary>
        /// Relación con el titular
        /// </summary>
        public string Relationship { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un titular con valores por defecto
        /// </summary>
        public Beneficiary() : base()
        {
            Owner = new();
            Name = string.Empty;
            Identification = string.Empty;
            IdentificationType = new();
            Relationship = string.Empty;
        }
        #endregion
    }
}
