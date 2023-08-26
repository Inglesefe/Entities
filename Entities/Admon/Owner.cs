using Entities.Config;

namespace Entities.Admon
{
    /// <summary>
    /// Titular de una matrícula
    /// </summary>
    public class Owner : EntityBase
    {
        #region Attributes
        /// <summary>
        /// Nombre del titular
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Número de identificación
        /// </summary>
        public string Identification { get; set; }

        /// <summary>
        /// Tipo de identificación
        /// </summary>
        public IdentificationType IdentificationType { get; set; }

        /// <summary>
        /// Dirección de la casa del titular
        /// </summary>
        public string AddressHome { get; set; }

        /// <summary>
        /// Dirección de la oficina del titular
        /// </summary>
        public string AddressOffice { get; set; }

        /// <summary>
        /// Teléfono de la casa del titular
        /// </summary>
        public string PhoneHome { get; set; }

        /// <summary>
        /// Teléfono de la oficina del titular
        /// </summary>
        public string PhoneOffice { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un titular con valores por defecto
        /// </summary>
        public Owner() : base()
        {
            Name = string.Empty;
            Identification = string.Empty;
            IdentificationType = new();
            AddressHome = string.Empty;
            AddressOffice = string.Empty;
            PhoneHome = string.Empty;
            PhoneOffice = string.Empty;
        }
        #endregion
    }
}
