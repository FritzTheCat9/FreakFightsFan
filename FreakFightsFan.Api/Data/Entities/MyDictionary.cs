﻿namespace FreakFightsFan.Api.Data.Entities
{
    public class MyDictionary : Entity
    {
        public string Name { get; set; }

        public List<MyDictionaryItem> DictionaryItems { get; set; }
    }
}
