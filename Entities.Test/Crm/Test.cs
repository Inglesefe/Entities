using Entities.Crm;

namespace Entities.Test.Crm
{
    /// <summary>
    /// Pruebas de creación de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creación de un beneficiario
        /// </summary>
        [Fact]
        public void CreateBeneficiary()
        {
            Assert.IsType<Beneficiary>(new Beneficiary());
        }

        /// <summary>
        /// Prueba la creación de un titular
        /// </summary>
        [Fact]
        public void CreateOwner()
        {
            Assert.IsType<Owner>(new Owner());
        }
    }
}
