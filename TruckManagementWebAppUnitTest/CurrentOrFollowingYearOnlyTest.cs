using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TruckManagementWebAppNetCore.Models.CustomValidation;

namespace TruckManagementWebAppUnitTest
{
    [TestClass]
    public class CurrentOrFollowingYearOnlyTest
    {
        [TestMethod]
        public void IsValid_MultipleYearsLesserThanCurrentShouldReturnFalse()
        {
            CurrentOrFollowingYearOnly validator = new CurrentOrFollowingYearOnly();

            string input = (DateTime.Now.Year - 2).ToString();

            bool response = validator.IsValid(input);

            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValid_OneYearLesserThanCurrentShouldReturnFalse()
        {
            CurrentOrFollowingYearOnly validator = new CurrentOrFollowingYearOnly();

            string input = (DateTime.Now.Year - 1).ToString();

            bool response = validator.IsValid(input);

            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValid_MultipleYearsGreaterThanCurrentShouldReturnFalse()
        {
            CurrentOrFollowingYearOnly validator = new CurrentOrFollowingYearOnly();

            string input = (DateTime.Now.Year + 2).ToString();

            bool response = validator.IsValid(input);

            Assert.IsFalse(response);
        }

        [TestMethod]
        public void IsValid_YearEqualThanCurrentShouldReturnTrue()
        {
            CurrentOrFollowingYearOnly validator = new CurrentOrFollowingYearOnly();

            string input = DateTime.Now.Year.ToString();

            bool response = validator.IsValid(input);

            Assert.IsTrue(response);
        }

        [TestMethod]
        public void IsValid_OneYearGreaterThanCurrentShouldReturnTrue()
        {
            CurrentOrFollowingYearOnly validator = new CurrentOrFollowingYearOnly();

            string input = (DateTime.Now.Year + 1).ToString();

            bool response = validator.IsValid(input);

            Assert.IsTrue(response);
        }
    }
}
