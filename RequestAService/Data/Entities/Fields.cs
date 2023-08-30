using System.ComponentModel.DataAnnotations;

namespace RequestAService.Data.Entities
{
    public class Fields
    {
        [Key]
        public int id { get; set; }

        public string Field { get; set; }
    }
}
