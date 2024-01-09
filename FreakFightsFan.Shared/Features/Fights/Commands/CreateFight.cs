using FluentValidation;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fights.Commands
{
    public class CreateFight
    {
        public class Command : IRequest<int>
        {
            public int EventId { get; set; }
            public List<CreateTeamModel> Teams { get; set; }
            public string VideoUrl { get; set; }
            public int? TypeId { get; set; }
        }

        public class CreateTeamModel
        {
            public List<TeamFighterModel> Fighters { get; set; }
        }

        public class TeamFighterModel
        {
            public int FighterId { get; set; }
            public FightResult FightResult { get; set; }
        }

        // Helper models for frontend

        public class TeamHelperModel
        {
            public int Number { get; set; }
            public List<FighterHelperModel> Fighters { get; set; }
        }

        public class FighterHelperModel
        {
            public FighterDto Fighter { get; set; }
            public FightResult FightResult { get; set; }
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
