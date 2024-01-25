using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Fighters.Responses;

namespace FreakFightsFan.Blazor.Pages.Tests
{
    public class TestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public MyDictionaryItemDto MyDictionaryItem { get; set; }
        public FighterDto Fighter { get; set; }
        public int Number { get; set; }
        public string ImageBase64 { get; set; }
    }
}
