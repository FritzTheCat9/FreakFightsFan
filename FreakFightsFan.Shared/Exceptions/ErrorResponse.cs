namespace FreakFightsFan.Shared.Exceptions;

public class ErrorResponse(ExceptionType type, string message)
{
    public ExceptionType Type { get; set; } = type;
    public string Message { get; set; } = message;
}

public class ValidationErrorResponse : ErrorResponse
{
    public Dictionary<string, List<string>> Errors { get; set; } = [];

    public ValidationErrorResponse(
        ExceptionType type,
        string message,
        Dictionary<string, List<string>> errors)
        : base(type, message)
    {
        Errors = errors;
    }
}

public class ServerErrorResponse(ExceptionType type, string message) : ErrorResponse(type, message);

public class UnauthorizedErrorResponse(ExceptionType type, string message) : ErrorResponse(type, message);

public class ForbiddenErrorResponse(ExceptionType type, string message) : ErrorResponse(type, message);

public class NotFoundErrorResponse(ExceptionType type, string message) : ErrorResponse(type, message);