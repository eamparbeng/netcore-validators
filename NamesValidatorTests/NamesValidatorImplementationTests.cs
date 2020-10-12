using NUnit.Framework;

namespace NamesValidatorTests
{
    public class NamesValidatorImplementationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_Name_Kofi_Validations_Is_Successful()
        {
            Assert.Pass();
        }

        [Test]
        public void Given_Name_Kkfi_Validations_IsNot_Successful()
        {
            Assert.Pass();
        }
    }
}