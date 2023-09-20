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
        /// Código de la escala
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la escala
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Valor de la comisión
        /// </summary>
        public int Comission { get; set; }

        /// <summary>
        /// Orden en que se muestra la escala en la matrícula
        /// </summary>
        public short Order { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una escala con valores por defecto
        /// </summary>
        public Scale()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
            Comission = 0;
            Order = 0;
        }
        #endregion
    }
}
