﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruckManagementWebAppNetCore.Models.CustomValidation
{
    public class CurrentOrFollowingYearOnly: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int currentYear = DateTime.Now.Year;

            return Convert.ToInt32(value) == currentYear || Convert.ToInt32(value) == (currentYear + 1);
        }
    }
}
