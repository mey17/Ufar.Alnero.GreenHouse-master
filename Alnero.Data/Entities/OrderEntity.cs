using System.ComponentModel.DataAnnotations;

namespace Alnero.Data.Entities
{
    public class OrderEntity
    {
        private string firstName;

        public  int Id { get; set; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
       
        public string StreetAddress { get; set; }

        public string PostalCode { get; set; }
    }
}
