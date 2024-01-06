using FluentValidation;
using FreakFightsFan.Shared.Exceptions;
using MediatR;

namespace FreakFightsFan.Api.Behaviors
{
    public class ValidationPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationPipelineBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var validationContext = new ValidationContext<TRequest>(request);

            var validationErrors = _validators.
                Select(validator => validator.Validate(validationContext))
                .Where(validationResult => !validationResult.IsValid)
                .SelectMany(validationResult => validationResult.Errors)
                .Select(validationFailure => new ValidationError(validationFailure.PropertyName, validationFailure.ErrorMessage))
                .ToList();

            var errors = GetValidationErrorsDictionary(validationErrors);

            if (errors.Any())
                throw new MyValidationException(errors);

            var result = await next();
            return result;
        }

        private static Dictionary<string, List<string>> GetValidationErrorsDictionary(List<ValidationError> validationErrors)
        {
            var propertyNames = new List<string>();
            foreach (var failure in validationErrors)
            {
                if (!propertyNames.Contains(failure.PropertyName))
                    propertyNames.Add(failure.PropertyName);
            }

            var errors = new Dictionary<string, List<string>>();
            foreach (var prop in propertyNames)
            {
                var errorMessages = new List<string>();
                foreach (var failure in validationErrors)
                {
                    if (prop == failure.PropertyName)
                        errorMessages.Add(failure.ErrorMessage);
                }
                errors.Add(prop, errorMessages);
            }

            return errors;
        }

        private class ValidationError
        {
            public string PropertyName { get; set; }
            public string ErrorMessage { get; set; }

            public ValidationError(string propertyName, string errorMessage)
            {
                PropertyName = propertyName;
                ErrorMessage = errorMessage;
            }
        }
    }
}
