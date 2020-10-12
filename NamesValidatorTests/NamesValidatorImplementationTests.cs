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
        public void Given_Name_Kkfs_Validations_IsNot_Successful()
        {
            Assert.IsFalse(namesValidator.IsValidName("Kkfs"));
        }

        [Test]
        public void Given_Name_AsanteKkfy_Validations_IsNot_Successful()
        {
            Assert.IsFalse(namesValidator.IsValidName("AsanteKkfy"));
        }

        [Test]
        public void Given_Name_Oeoi_Validations_IsNot_Successful()
        {
            Assert.IsFalse(namesValidator.IsValidName("Oeoi"));
        }

        [Test]
        public void Given_Name_Vwwwdfaawf_Validations_IsNot_Successful()
        {
            Assert.IsFalse(namesValidator.IsValidName("Vwwwdfaawf"));
        }

        [Test]
        public void Given_Name_Ericsson_Validations_Is_Successful()
        {
            Assert.IsTrue(namesValidator.IsValidName("Ericsson"));
        }

        [Test]
        public void Given_Name_Olaf_Validations_Is_Successful()
        {
            Assert.IsTrue(namesValidator.IsValidName("Olaf"));
        }


        [Test]
        public void Given_Name_eric_Validations_IsNot_Successful()
        {
            Assert.IsFalse(namesValidator.IsValidName("eric"));
        }

    }
}