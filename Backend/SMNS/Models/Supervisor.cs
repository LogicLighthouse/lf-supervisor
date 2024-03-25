using System.Text.Json.Serialization;

namespace SMNS.Models
{
    public class Supervisor
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("jurisdiction")]
        public string Jurisdiction { get; set; }

        [JsonPropertyName("identificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
    }
}
