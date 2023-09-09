using Entities.Config;

namespace Entities.Admon
{
    /// <summary>
    /// Relación entre una matrícula de un estudiante, una escala y el ejecutivo de cuenta al que se le asigna
    /// </summary>
    public class RegistrationScale : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único de la relación
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Escala asignada al ejecutivo de cuenta en la matrícula
        /// </summary>
        public Scale Scale { get; set; }

        /// <summary>
        /// Ejecutivo de cuenta que fue asignado en la escala en la matrícula
        /// </summary>
        public AccountExecutive AccountExecutive { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea un titular con valores por defecto
        /// </summary>
        public RegistrationScale()
        {
            Id = 0;
            Scale = new();
            AccountExecutive = new();
        }
        #endregion
    }
}
