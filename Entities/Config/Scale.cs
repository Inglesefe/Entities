namespace Entities.Config
{
    /// <summary>
    /// Escala de comisiones
    /// </summary>
    public class Scale : IEntity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del ejecutivo de cuenta
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la escala
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Valor de la comisión
        /// </summary>
        public int Comission { get; set; }

        /// <summary>
        /// Fecha en que entra en vigencia las escalas
        /// </summary>
        public DateTime Validity { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una escala con valores por defecto
        /// </summary>
        public Scale()
        {
            Id = 0;
            Name = string.Empty;
            Comission = 0;
            Validity = DateTime.MinValue;
        }
        #endregion
    }
}
