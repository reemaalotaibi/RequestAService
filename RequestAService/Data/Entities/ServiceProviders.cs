using System.ComponentModel.DataAnnotations;

namespace RequestAService.Data.Entities
{
    public class ServiceProviders
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string NationalId { get; set; }

        public string Nationality { get; set; }

        public int yearOfExperience { get; set; }

        public string GraduationField { get; set; }

        public float Rating { get; set; }

        public Fields FieldId { get; set; }
    }
}
