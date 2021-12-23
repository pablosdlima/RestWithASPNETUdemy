using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.VO
{
    public class PersonVO
    {
        [JsonPropertyName("Code")] //"data annotations" de api
        public long Id { get; set; }

        [JsonPropertyName("Name")]
        public string FirstName { get; set; }

        [JsonPropertyName("Last")]
        public string LastName { get; set; }

        [JsonIgnore]
        public string Address { get; set; }

        [JsonPropertyName("Sex")]
        public string Gender { get; set; }
    }
}
