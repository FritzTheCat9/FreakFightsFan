namespace FreakFightsFan.Api.Data.Entities
{
    public class MyDictionaryItem : Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public int DictionaryId { get; set; }
        public MyDictionary Dictionary { get; set; }
    }
}
