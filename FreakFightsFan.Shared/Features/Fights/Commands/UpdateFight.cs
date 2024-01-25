using FluentValidation;
using FreakFightsFan.Shared.Features.Fights.Helpers;
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
                RuleFor(x => x.Teams)
                    .NotEmpty()
                    .Must(teams => teams.Count >= FightsConsts.MinTeamsNumber)
                    .WithMessage($"At least {FightsConsts.MinTeamsNumber} teams should be added for each fight")
                    .Must(teams => teams.Count <= FightsConsts.MaxTeamsNumber)
                    .WithMessage($"Each fight can contain only {FightsConsts.MaxTeamsNumber} teams")
                    .Must(FightHelpers.HaveUniqueFighters)
                    .WithMessage("Each fighter can only be selected to the team once");

                RuleForEach(x => x.Teams)
                    .Must(team => team.Fighters.Count >= FightsConsts.MinTeamFighters)
                    .WithMessage($"At least {FightsConsts.MinTeamFighters} fighter should be added for each team")
                    .Must(team => team.Fighters.Count <= FightsConsts.MaxTeamFighters)
                    .WithMessage($"Each team can contain only {FightsConsts.MaxTeamFighters} fighters");

                When(x => !string.IsNullOrWhiteSpace(x.VideoUrl), () =>
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
