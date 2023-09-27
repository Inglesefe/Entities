namespace Entities.Config
{
    /// <summary>
    /// Escala de comisiones
    /// </summary>
    public class Scale : Entity
    {
        #region Attributes
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
        public Scale() : base()
        {
            Code = string.Empty;
            Name = string.Empty;
            Comission = 0;
            Order = 0;
        }
        #endregion
    }
}
