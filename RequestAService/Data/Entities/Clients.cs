using System.ComponentModel.DataAnnotations;

namespace RequestAService.Data.Entities
{
    public class Clients
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Location { get; set; }
        public int NumberOfServicesBought { get; set; }


       
        

    }
}
