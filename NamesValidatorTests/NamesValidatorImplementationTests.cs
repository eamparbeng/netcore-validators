using NUnit.Framework;
using NamesValidator;

namespace NamesValidatorTests
{
    public class NamesValidatorImplementationTests
    {
        private NamesValidatorImplementation namesValidator;

        [SetUp]
        public void Setup()
        {
            namesValidator = new NamesValidatorImplementation();
        }

        [Test]
        public void Given_Name_Kofi_Validations_Is_Successful()
        {
            Assert.IsTrue(namesValidator.IsValidName("Kofi"));
        }

        [Test]
        public void Given_Name_Amparbeng_Validations_Is_Successful()
        {
            Assert.IsTrue(namesValidator.IsValidName("Amparbeng"));
        }

        [Test]
        public void Given_Name_Kkfi_Validations_IsNot_Successful()
        {
            Assert.IsFalse(namesValidator.IsValidName("Kkfi"));
        }

        [Test]
        public void Given_Name_AsanteKkfi_Validations_IsNot_Successful()
        {
            Assert.IsFalse(namesValidator.IsValidName("AsanteKkfi"));
        }
    }
}