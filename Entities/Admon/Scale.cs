namespace Entities.Admon
{
    /// <summary>
    /// Escala de comisiones
    /// </summary>
    public class Scale : EntityBase
    {
        #region Attributes
        /// <summary>
        /// Nombre de la escala
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Valor de la comisión
        /// </summary>
        public int Comission { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una escala con valores por defecto
        /// </summary>
        public Scale() : base()
        {
            Name = string.Empty;
            Comission = 0;
        }
        #endregion
    }
}
