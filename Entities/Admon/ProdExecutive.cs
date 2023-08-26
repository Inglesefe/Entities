using Entities.Config;

namespace Entities.Admon
{
    /// <summary>
    /// Ejecutivo de producción de la matrícula
    /// </summary>
    public class ProdExecutive : EntityBase
    {
        #region Attributes
        /// <summary>
        /// Oficina a la que pertenece un ejecutivo de producción
        /// </summary>
        public Office Office { get; set; }

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
        public ProdExecutive() : base()
        {
            Office = new();
            Name = string.Empty;
            Identification = string.Empty;
            IdentificationType = new();
        }
        #endregion
    }
}
