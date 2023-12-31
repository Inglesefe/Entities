﻿using Entities.Config;

namespace Entities.Admon
{
    /// <summary>
    /// Relación entre una matrícula de un estudiante, una escala y el ejecutivo de cuenta al que se le asigna
    /// </summary>
    public class RegistrationScale : Entity
    {
        #region Attributes
        /// <summary>
        /// MAtrícula a la que pertenece la relación
        /// </summary>
        public Registration Registration { get; set; }

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
        public RegistrationScale() : base()
        {
            Registration = new();
            Scale = new();
            AccountExecutive = new();
        }
        #endregion
    }
}
