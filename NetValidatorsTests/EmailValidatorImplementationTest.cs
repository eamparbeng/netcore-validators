using NetValidators;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetValidatorsTests
{
    public class EmailValidatorImplementationTest
    {
        private EmailValidatorImplementation emailValidator;

        [SetUp]
        public void Setup()
        {
            emailValidator = new EmailValidatorImplementation();
        }

        [Test]
        public void GetValidEmailFromGiven()
        {
            Assert.IsTrue(emailValidator.IsValidEmail("grahamasare62@outlook.com"));
        }

        [Test]
        public void GetInvalidEmailFromGiven()
        {
            Assert.IsFalse(emailValidator.IsValidEmail("fdsa"));
        }

        [Test]
        public void GetInvalidEmailFromGiven1()
        {
            Assert.IsFalse(emailValidator.IsValidEmail("fdsa"));
        }

        [Test]
        public void GetInvalidEmailFromGiven2()
        {
            Assert.IsFalse(emailValidator.IsValidEmail("fdsa"));
        }

        [Test]
        public void GetInvalidEmailFromGiven3()
        {
            Assert.IsFalse(emailValidator.IsValidEmail("fdsa@"));
        }

        [Test]
        public void GetInvalidEmailFromGiven4()
        {
            Assert.IsFalse(emailValidator.IsValidEmail("fdsa@fdsa"));
        }

        [Test]
        public void GetInvalidEmailFromGiven5()
        {
            Assert.IsFalse(emailValidator.IsValidEmail("fdsa@fdsa."));
        }
    }
}
