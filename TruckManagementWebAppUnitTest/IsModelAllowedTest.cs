using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using TruckManagementWebAppNetCore.Models;
using TruckManagementWebAppNetCore.Models.CustomValidation;

namespace TruckManagementWebAppUnitTest
{
    [TestClass]
    public class IsModelAllowedTest
    {

        string DEFAULT_REQUIRED_ERROR_MESSAGE = "O modelo é obrigatório.";
        string DEFAULT_FORBIDDEN_MODEL_ERROR_MESSAGE = "Os modelos permitidos são FH ou FM.";

        [TestMethod]
        public void ValidateModelId_InvalidModelIdShouldReturnErrorMessage()
        {
            IsModelAllowed validator = new IsModelAllowed();

            Truck truck = new Truck {
                ModelId = 0
            };

            string validationMessage = validator.ValidateModelId(truck.ModelId);

            Assert.IsTrue(validationMessage != null);
        }

        [TestMethod]
        public void ValidateModelId_InvalidModelIdShouldReturnRequiredErrorMessage()
        {
            IsModelAllowed validator = new IsModelAllowed();

            Truck truck = new Truck
            {
                ModelId = 0
            };

            string validationMessage = validator.ValidateModelId(truck.ModelId);

            Assert.IsTrue(validationMessage == DEFAULT_REQUIRED_ERROR_MESSAGE);
        }

        [TestMethod]
        public void ValidateModelId_ForbiddenModelIdShouldReturnErrorMessage()
        {
            IsModelAllowed validator = new IsModelAllowed();

            Truck truck = new Truck
            {
                ModelId = 3
            };

            string validationMessage = validator.ValidateModelId(truck.ModelId);

            Assert.IsTrue(validationMessage != null);
        }

        [TestMethod]
        public void ValidateModelId_ForbiddenModelIdShouldReturnForbiddenErrorMessage()
        {
            IsModelAllowed validator = new IsModelAllowed();

            Truck truck = new Truck
            {
                ModelId = 3
            };

            string validationMessage = validator.ValidateModelId(truck.ModelId);

            Assert.IsTrue(validationMessage == DEFAULT_FORBIDDEN_MODEL_ERROR_MESSAGE);
        }

        [TestMethod]
        public void ValidateModelId_ValidModelIdShouldNotReturnErrorMessage()
        {
            IsModelAllowed validator = new IsModelAllowed();

            Truck truck = new Truck
            {
                ModelId = 1
            };

            string validationMessage = validator.ValidateModelId(truck.ModelId);

            Assert.IsTrue(validationMessage == null);
        }
    }
}
