using Entities.Config;

namespace Entities.Test.Config
{
    /// <summary>
    /// Pruebas de creación de las entidades
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Prueba la creación de una ciudad
        /// </summary>
        [Fact]
        public void CreateCity()
        {
            Assert.IsType<City>(new City());
        }

        /// <summary>
        /// Prueba la creación de un país
        /// </summary>
        [Fact]
        public void CreateCountry()
        {
            Assert.IsType<Country>(new Country());
        }

        /// <summary>
        /// Prueba la creación de un tipo de identificación
        /// </summary>
        [Fact]
        public void CreateIdentificationType()
        {
            Assert.IsType<IdentificationType>(new IdentificationType());
        }

        /// <summary>
        /// Prueba la creación de un tipo de ingreso
        /// </summary>
        [Fact]
        public void CreateIncomeType()
        {
            Assert.IsType<IncomeType>(new IncomeType());
        }

        /// <summary>
        /// Prueba la creación de una oficina
        /// </summary>
        [Fact]
        public void CreateOffice()
        {
            Assert.IsType<Office>(new Office());
        }

        /// <summary>
        /// Prueba la creación de un parámetro
        /// </summary>
        [Fact]
        public void CreateParamter()
        {
            Assert.IsType<Parameter>(new Parameter());
        }

        /// <summary>
        /// Prueba la creación de un tipo de pago
        /// </summary>
        [Fact]
        public void CreatePaymentType()
        {
            Assert.IsType<PaymentType>(new PaymentType());
        }

        /// <summary>
        /// Prueba la creación de un plan
        /// </summary>
        [Fact]
        public void CreatePlan()
        {
            Assert.IsType<Plan>(new Plan());
        }

        /// <summary>
        /// Prueba la creación de una escala de comisiones
        /// </summary>
        [Fact]
        public void CreateScale()
        {
            Assert.IsType<Scale>(new Scale());
        }
    }
}
