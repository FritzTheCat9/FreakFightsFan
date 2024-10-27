using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;

namespace FreakFightsFan.Api.Services;

public interface IMyDictionaryService
{
    Task<bool> ItemIsFromDictionary(int dictionaryItemId, string dictionaryCode);
}

public class MyDictionaryService(IMyDictionaryRepository dictionaryRepository) : IMyDictionaryService
{
    public async Task<bool> ItemIsFromDictionary(int dictionaryItemId, string dictionaryCode)
    {
        var dictionary = await dictionaryRepository.Get(dictionaryCode) ?? throw new MyNotFoundException();

        return dictionary.DictionaryItems.Any(x => x.Id == dictionaryItemId);
    }
}