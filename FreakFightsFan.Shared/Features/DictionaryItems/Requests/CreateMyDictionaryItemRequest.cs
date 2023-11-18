namespace FreakFightsFan.Shared.Features.DictionaryItems.Requests
{
    public class CreateMyDictionaryItemRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int DictionaryId { get; set; }
    }
}
