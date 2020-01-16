namespace todo.Models
{
    using Newtonsoft.Json;

    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Nume Prenume")]
        public string NumePrenume { get; set; }

        [JsonProperty(PropertyName = "Data")]
        public string Data { get; set; }

        [JsonProperty(PropertyName = "Motiv")]
        public string Motiv { get; set; }

        [JsonProperty(PropertyName = "Complet")]
        public bool Complet { get; set; }
    }
}
