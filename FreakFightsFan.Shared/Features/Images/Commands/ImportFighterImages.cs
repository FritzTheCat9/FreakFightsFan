using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Images.Commands;

public static class ImportFighterImages
{
    public class ImportFighterImagesCommand : IRequest<Unit> { }

    public class Validator : AbstractValidator<ImportFighterImagesCommand> { }
}