using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Images.Commands
{
    public class ImportFighterImages
    {
        public class ImportFighterImagesCommand : IRequest<Unit>
        {

        }

        public class Validator : AbstractValidator<ImportFighterImagesCommand>
        {
            public Validator()
            {

            }
        }
    }
}
