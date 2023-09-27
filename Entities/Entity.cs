namespace Entities
{
    /// <summary>
    /// Clase padre de la jerarquía de entidades
    /// </summary>
    public abstract class Entity
    {
        #region Attributes
        /// <summary>
        /// Identificador único del ejecutivo de cuenta
        /// </summary>
        public int Id { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una entidad con valores por defecto
        /// </summary>
        protected Entity()
        {
            Id = 0;
        }
        #endregion
    }
}