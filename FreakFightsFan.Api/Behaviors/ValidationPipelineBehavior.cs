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

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            var validationContext = new ValidationContext<TRequest>(request);

            var errors = _validators
                .Select(validator => validator.Validate(validationContext))
                .Where(validationResult => !validationResult.IsValid)
                .SelectMany(validationResult => validationResult.Errors)
                .Select(validationFailure => new ValidationError(
                    validationFailure.PropertyName,
                    validationFailure.ErrorMessage))
                .GroupBy(failure => failure.PropertyName)
                .ToDictionary(group => group.Key, group => group.Select(failure => failure.ErrorMessage)
                                                                .ToList());

            if (errors.Any())
                throw new MyValidationException(errors);

            var result = await next();
            return result;
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
