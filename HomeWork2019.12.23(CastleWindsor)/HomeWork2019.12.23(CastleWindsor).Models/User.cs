using HomeWork2019._12._23_CastleWindsor_.AbstractModels;
using Newtonsoft.Json;

namespace HomeWork2019._12._23_1_.Models
{
    public class User : IEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }
}
