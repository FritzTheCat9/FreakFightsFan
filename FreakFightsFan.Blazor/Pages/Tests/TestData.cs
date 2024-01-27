using FreakFightsFan.Shared.Features.DictionaryItems.Responses;

namespace FreakFightsFan.Blazor.Pages.Tests
{
    public static class TestData
    {
        private static readonly List<TestDto> _tests =
        [
            new() { Id = 1, Name = "Test 1", Date = new DateTime(), Number = 1, ImageBase64 = null, Fighter = null, MyDictionaryItem = null },
            new() { Id = 2, Name = "Test 2", Date = new DateTime(), Number = 2, ImageBase64 = null, Fighter = null, MyDictionaryItem = null },
        ];

        private static readonly List<MyDictionaryItemDto> _items = new List<MyDictionaryItemDto>()
        {
                new() { Id = 1, DictionaryId = 1, Code = "KOSZALIN", Name = "Koszalin", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 2, DictionaryId = 1, Code = "POZNAN", Name = "Poznań", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 3, DictionaryId = 1, Code = "LODZ", Name = "Łódź", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 4, DictionaryId = 1, Code = "CZESTOCHOWA", Name = "Częstochowa", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 5, DictionaryId = 1, Code = "GDANSK_SOPOT", Name = "Gdańsk/Sopot", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 6, DictionaryId = 1, Code = "NIEPORAZ", Name = "Nieporaz", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 7, DictionaryId = 1, Code = "GLIWICE", Name = "Gliwice", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 8, DictionaryId = 1, Code = "KRAKOW", Name = "Kraków", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 9, DictionaryId = 1, Code = "NEWCASTLE", Name = "Newcastle", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 10, DictionaryId = 1, Code = "WROCLAW", Name = "Wrocław", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 11, DictionaryId = 1, Code = "SZCZECIN", Name = "Szczecin", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 24, DictionaryId = 1, Code = "GDYNIA", Name = "Gdynia", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 26, DictionaryId = 1, Code = "RADOM", Name = "Radom", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 29, DictionaryId = 1, Code = "TORUN", Name = "Toruń", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 31, DictionaryId = 1, Code = "WARSZAWA", Name = "Warszawa", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 33, DictionaryId = 1, Code = "KATOWICE", Name = "Katowice", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 36, DictionaryId = 1, Code = "PLOCK", Name = "Płock", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 38, DictionaryId = 1, Code = "ZIELONA_GORA", Name = "Zielona Góra", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
                new() { Id = 41, DictionaryId = 1, Code = "JASIONKA", Name = "Jasionka", Created = DateTime.UtcNow, Modified = DateTime.UtcNow },
        };

        public static List<TestDto> GetTests() => _tests;

        public static void AddTest(CreateTest.Command command)
        {
            _tests.Add(new TestDto
            {
                Id = _tests.Max(x => x.Id) + 1,
                Name = command.Name,
                Date = command.Date,
                Fighter = command.Fighter,
                MyDictionaryItem = _items.First(x => x.Id == command.DictionaryItemId),
                ImageBase64 = command.ImageBase64,
                Number = command.Number
            });
        }

        public static void UpdateTest(UpdateTest.Command command)
        {
            var toUpdate = _tests.FirstOrDefault(x => x.Id == command.Id);

            if (toUpdate is not null)
            {
                toUpdate.Name = command.Name;
                toUpdate.Date = command.Date;
                toUpdate.Fighter = command.Fighter;
                toUpdate.MyDictionaryItem = _items.First(x => x.Id == command.DictionaryItemId);
                toUpdate.ImageBase64 = command.ImageBase64;
                toUpdate.Number = command.Number;
            }
        }

        public static void DeleteTest(int id)
        {
            var toRemove = _tests.FirstOrDefault(x => x.Id == id);

            if (toRemove is not null)
            {
                _tests.Remove(toRemove);
            }
        }
    }
}
