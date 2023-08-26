using Entities.Admon;

namespace Entities.Test.Admon
{
    /// <summary>
    /// Pruebas de creación de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creación de un titular
        /// </summary>
        [Fact]
        public void CreateOwner()
        {
            Assert.IsType<Owner>(new Owner());
        }

        /// <summary>
        /// Prueba la creación de un beneficiario
        /// </summary>
        [Fact]
        public void CreateBeneficiary()
        {
            Assert.IsType<Beneficiary>(new Beneficiary());
        }

        /// <summary>
        /// Prueba la creación de una escala
        /// </summary>
        [Fact]
        public void CreateScale()
        {
            Assert.IsType<Scale>(new Scale());
        }

        /// <summary>
        /// Prueba la creación de un ejecutivo de producción
        /// </summary>
        [Fact]
        public void CreateProdExecutive()
        {
            Assert.IsType<ProdExecutive>(new ProdExecutive());
        }
    }
}