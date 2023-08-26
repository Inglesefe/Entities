using Entities.Admon;

namespace Entities.Test.Admon
{
    /// <summary>
    /// Pruebas de creaci�n de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creaci�n de un titular
        /// </summary>
        [Fact]
        public void CreateOwner()
        {
            Assert.IsType<Owner>(new Owner());
        }

        /// <summary>
        /// Prueba la creaci�n de un beneficiario
        /// </summary>
        [Fact]
        public void CreateBeneficiary()
        {
            Assert.IsType<Beneficiary>(new Beneficiary());
        }

        /// <summary>
        /// Prueba la creaci�n de una escala
        /// </summary>
        [Fact]
        public void CreateScale()
        {
            Assert.IsType<Scale>(new Scale());
        }

        /// <summary>
        /// Prueba la creaci�n de un ejecutivo de producci�n
        /// </summary>
        [Fact]
        public void CreateProdExecutive()
        {
            Assert.IsType<ProdExecutive>(new ProdExecutive());
        }
    }
}