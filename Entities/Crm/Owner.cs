using Entities.Config;

namespace Entities.Crm
{
    /// <summary>
    /// Titular de una matrícula
    /// </summary>
    public class Owner : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del titular
        /// </summary>
        public int Id { get; set; }

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

        /// <summary>
        /// Email del titular
        /// </summary>
        public string Email { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un titular con valores por defecto
        /// </summary>
        public Owner()
        {
            Id = 0;
            Name = string.Empty;
            Identification = string.Empty;
            IdentificationType = new();
            AddressHome = string.Empty;
            AddressOffice = string.Empty;
            PhoneHome = string.Empty;
            PhoneOffice = string.Empty;
            Email = string.Empty;
        }
        #endregion
    }
}
