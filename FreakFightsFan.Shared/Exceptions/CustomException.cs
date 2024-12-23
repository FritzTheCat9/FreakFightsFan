﻿namespace FreakFightsFan.Shared.Exceptions;

public abstract class CustomException(string message) : Exception(message)
{
    public ExceptionType Type { get; protected init; }
}

public class MyValidationException : CustomException
{
    private const string _errorMessage = "Validation Error";

    public MyValidationException(Dictionary<string, List<string>> errors) : base(_errorMessage)
    {
        Type = ExceptionType.Validation;
        Errors = errors;
    }

    public MyValidationException(string propertyName, string error) : base(_errorMessage)
    {
        Type = ExceptionType.Validation;
        Errors.Add(propertyName, [error]);
    }

    public Dictionary<string, List<string>> Errors { get; set; } = [];
}

public class MyServerException : CustomException
{
    private const string _errorMessage = "Server Error";

    public MyServerException() : base(_errorMessage)
    {
        Type = ExceptionType.Server;
    }
}

public class MyUnauthorizedException : CustomException
{
    private const string _errorMessage = "Unauthorized Error";

    public MyUnauthorizedException() : base(_errorMessage)
    {
        Type = ExceptionType.Unauthorized;
    }
}

public class MyForbiddenException : CustomException
{
    private const string _errorMessage = "Forbidden Error";

    public MyForbiddenException() : base(_errorMessage)
    {
        Type = ExceptionType.Forbidden;
    }
}

public class MyNotFoundException : CustomException
{
    private const string _errorMessage = "Not Found Error";

    //public string Details { get; set; }

    public MyNotFoundException( /*string details*/) : base(_errorMessage)
    {
        Type = ExceptionType.NotFound;
        //Details = details;
    }
}