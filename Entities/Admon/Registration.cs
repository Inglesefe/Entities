using Entities.Config;
using Entities.Crm;

namespace Entities.Admon
{
    /// <summary>
    /// Matrícula de un estudiante de los cursos de inglés ofrecidos por la empresa
    /// </summary>
    public class Registration : Entity
    {
        #region Attributes
        /// <summary>
        /// Oficina en la que se realizó la matrícula
        /// </summary>
        public Office Office { get; set; }

        /// <summary>
        /// Fecha de la matrícula
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Número de contrato asociado a la matrícula
        /// </summary>
        public string ContractNumber { get; set; }

        /// <summary>
        /// Titular de la matrícula
        /// </summary>
        public Owner Owner { get; set; }

        /// <summary>
        /// Primer beneficiario de la matrícula
        /// </summary>
        public Beneficiary? Beneficiary1 { get; set; }

        /// <summary>
        /// Segundo beneficiario de la matrícula
        /// </summary>
        public Beneficiary? Beneficiary2 { get; set; }

        /// <summary>
        /// Plan de estudio al que se matriculó
        /// </summary>
        public Plan Plan { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un titular con valores por defecto
        /// </summary>
        public Registration() : base()
        {
            Office = new();
            Date = DateTime.MinValue;
            ContractNumber = string.Empty;
            Owner = new();
            Beneficiary1 = null;
            Beneficiary2 = null;
            Plan = new();
        }
        #endregion
    }
}
