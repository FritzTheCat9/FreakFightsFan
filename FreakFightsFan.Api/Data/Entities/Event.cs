namespace FreakFightsFan.Api.Data.Entities
{
    public class Event : Entity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public int FederationId { get; set; }
        public Federation Federation { get; set; }
        public int? CityId { get; set; }
        public MyDictionaryItem? City { get; set; }
        public List<Fight> Fights { get; } = [];
    }
}
