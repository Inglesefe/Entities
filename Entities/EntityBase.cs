namespace Entities
{
    /// <summary>
    /// Clase padre de la jerarquía de entidades
    /// </summary>
    public abstract class EntityBase
    {
        #region Attributes
        /// <summary>
        /// Identificador único de la entidad
        /// </summary>
        public long Id { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Crea una entidad con valores por defecto
        /// </summary>
        protected EntityBase()
        {
            Id = 0;
        }
        #endregion
    }
}