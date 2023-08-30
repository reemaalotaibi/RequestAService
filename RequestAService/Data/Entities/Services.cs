using System.ComponentModel.DataAnnotations;

namespace RequestAService.Data.Entities
{
    public class Services
    {
        public int id { get; set; }

        public string ServiceName { get; set; }

        public Clients clientName { get; set; }
        public ServiceProviders serviceProviderName { get; set; }
    }
}
