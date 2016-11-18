using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace testerino.Validations
{
    public class QuantityValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int? TotalQuantity = (int?)validationContext.ObjectType.GetProperty("TotalQuantity").GetValue(validationContext.ObjectInstance, null);
            int? QuantityRemaining = (int?)validationContext.ObjectType.GetProperty("QuantityRemaining").GetValue(validationContext.ObjectInstance, null);

            if (TotalQuantity == null && QuantityRemaining == null)
            {
                return new ValidationResult("You must enter at least Total or Remaining");
                //return ValidationResult.Success;
            }
            return ValidationResult.Success;
        }
    }
}
