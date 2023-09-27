namespace Entities.Config
{
    /// <summary>
    /// Oficina en una ciudad
    /// </summary>
    public class Office : Entity
    {
        #region Attributes
        /// <summary>
        /// Ciudad a la que pertenece la oficina
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Nombre de la oficina
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Dirección de la oficina
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Número de teléfono de la oficina
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Si la oficina está o no activa
        /// </summary>
        public bool Active { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una ciudad con valores por defecto
        /// </summary>
        public Office() : base()
        {
            City = new();
            Name = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;
            Active = false;
        }
        #endregion
    }
}
