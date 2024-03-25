using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMNS.Models
{
    public class NotificationRequest : IValidatableObject
    {
        [Required(ErrorMessage = "First name is required.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "First name must only contain letters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Last name must only contain letters.")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Supervisor is required.")]
        public string Supervisor { get; set; }

        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstName.Equals(LastName, System.StringComparison.OrdinalIgnoreCase))
            {
                yield return new ValidationResult(
                    "First name and last name cannot be the same.",
                    new[] { nameof(FirstName), nameof(LastName) });
            }
        }
    }
}
