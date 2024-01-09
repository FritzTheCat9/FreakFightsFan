using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fights.Commands
{
    public class UpdateFight
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public List<CreateFight.CreateTeamModel> Teams { get; set; }
            public string VideoUrl { get; set; }
            public int? TypeId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                When(x => !string.IsNullOrEmpty(x.VideoUrl), () =>
                {
                    RuleFor(x => x.VideoUrl)
                        .NotEmpty()
                        .Matches("^(?:https?:\\/\\/)?(?:www\\.)?(?:youtube\\.com\\/(?:[^\\/\\n\\s]+\\/\\S+\\/|(?:v|e(?:mbed)?)\\/|\\S*?[?&]v=)|youtu\\.be\\/)([a-zA-Z0-9_-]{11})")
                        .WithMessage("This is not a valid link to the YouTube video");
                });
            }
        }
    }
}
