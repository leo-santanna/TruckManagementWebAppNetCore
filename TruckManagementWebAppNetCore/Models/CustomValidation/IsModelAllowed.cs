using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruckManagementWebAppNetCore.Models.CustomValidation
{
    public class IsModelAllowed: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Truck truck = (Truck)validationContext.ObjectInstance;

            string validationResult = ValidateModelId(truck.ModelId);

            if (validationResult == null)
                return ValidationResult.Success;

            return new ValidationResult(validationResult);
        }

        public string ValidateModelId(int modelId)
        {
            int[] allowedModelIds = { 1, 2 };

            if (modelId <= 0)
                return "O modelo é obrigatório.";

            if (!allowedModelIds.Contains(modelId))
                return "Os modelos permitidos são FH ou FM.";

            return null;
        }
    }
}
