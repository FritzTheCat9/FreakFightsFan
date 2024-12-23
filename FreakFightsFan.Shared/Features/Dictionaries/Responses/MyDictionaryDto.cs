﻿namespace FreakFightsFan.Shared.Features.Dictionaries.Responses;

public class MyDictionaryDto
{
    public int Id { get; init; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public string Name { get; set; }
    public string Code { get; set; }
}