using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TruckManagementWebAppNetCore.Models.CustomValidation;

namespace TruckManagementWebAppUnitTest
{
    [TestClass]
    public class CurrentYearOnlyTest
    {
        [TestMethod]
        public void IsValid_MultipleYearsLesserThanCurrentShouldReturnFalse()
        {
            CurrentYearOnly validator = new CurrentYearOnly();

            string input = (DateTime.Now.Year - 2).ToString();

            bool response = validator.IsValid(input);

            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValid_YearLesserThanCurrentShouldReturnFalse()
        {
            CurrentYearOnly validator = new CurrentYearOnly();

            string input = (DateTime.Now.Year - 1).ToString();

            bool response = validator.IsValid(input);

            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValid_YearGreaterThanCurrentShouldReturnFalse()
        {
            CurrentYearOnly validator = new CurrentYearOnly();

            string input = (DateTime.Now.Year + 1).ToString();

            bool response = validator.IsValid(input);

            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValid_MultipleYearsGreaterThanCurrentShouldReturnFalse()
        {
            CurrentYearOnly validator = new CurrentYearOnly();

            string input = (DateTime.Now.Year + 2).ToString();

            bool response = validator.IsValid(input);

            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValid_YearEqualThanCurrentShouldReturnTrue()
        {
            CurrentYearOnly validator = new CurrentYearOnly();

            string input = DateTime.Now.Year.ToString();

            bool response = validator.IsValid(input);

            Assert.IsTrue(response);
        }
    }
}
