using System.ComponentModel.DataAnnotations;

namespace Alnero.Data.Entities
{
    public class OrderEntity
    {
        private string firstName;

        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 50 characters")]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "First name can only contain letters")]
        public string FirstName
        {
            get => firstName;
            set => firstName = value?.Trim(); // Trim leading and trailing whitespace
        }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Last name must be between 1 and 50 characters")]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "Last name can only contain letters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Phone number must be 8 digits")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public string Province { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }

        [RegularExpression(@"^\d{4}$", ErrorMessage = "Postal code must be 4 digits")]
        public string PostalCode { get; set; }
    }
}
