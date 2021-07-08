using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using TruckManagementWebAppNetCore.Models;
using TruckManagementWebAppNetCore.Models.CustomValidation;

namespace TruckManagementWebAppUnitTest
{
    [TestClass]
    public class TruckTest
    {

        string DEFAULT_MISSING_MANUFACTURE_YEAR_ERROR_MESSAGE = "O ano de fabricação é obrigatório.";
        string DEFAULT_MISSING_MODEL_YEAR_ERROR_MESSAGE = "O ano do modelo é obrigatório.";

        [TestMethod]
        public void ValidateTruck_MissingManufactureYearShouldReturnError()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();

            Truck truck = new Truck
            {
                ModelId = 1,
                ModelYear = "2021",
            };

            var result = cpv.Validate(truck);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(DEFAULT_MISSING_MANUFACTURE_YEAR_ERROR_MESSAGE, result[0].ErrorMessage);
        }

        [TestMethod]
        public void ValidateTruck_MissingModelYearShouldReturnError()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();

            Truck truck = new Truck
            {
                ModelId = 1,
                ManufactureYear = "2021",
            };

            var result = cpv.Validate(truck);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(DEFAULT_MISSING_MODEL_YEAR_ERROR_MESSAGE, result[0].ErrorMessage);
        }

        [TestMethod]
        public void ValidateTruck_ValidTruckShouldReturnNoError()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();

            Truck truck = new Truck
            {
                ModelId = 2,
                ModelYear = "2021",
                ManufactureYear = "2021"
            };

            var result = cpv.Validate(truck);

            Assert.AreEqual(0, result.Count);
        }


    }
}
