using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using TruckManagementWebAppNetCore.Models;
using TruckManagementWebAppNetCore.Models.CustomValidation;

namespace TruckManagementWebAppUnitTest
{
    [TestClass]
    public class TruckModelTest
    {

        [TestMethod]
        public void ValidateTruckModel_MissingNameShouldReturnError()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();

            TruckModel truckModel = new TruckModel
            {
                
            };

            var result = cpv.Validate(truckModel);

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void ValidateTruckModel_ValidTruckModelShouldReturnNoError()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();

            TruckModel truckModel = new TruckModel
            {
                Name = "FM"
            };

            var result = cpv.Validate(truckModel);

            Assert.AreEqual(0, result.Count);
        }


    }
}
