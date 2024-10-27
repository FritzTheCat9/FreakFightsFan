using FluentValidation;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Fights.Commands;

public static class UpdateFight
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
        public Validator(IStringLocalizer<ValidationMessage> localizer)
        {
            RuleFor(x => x.Teams)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsNotEmpty)])
                .Must(teams => teams.Count >= FightsConsts.MinTeamsNumber)
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsMinNumber), FightsConsts.MinTeamsNumber])
                .Must(teams => teams.Count <= FightsConsts.MaxTeamsNumber)
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsMaxNumber), FightsConsts.MaxTeamsNumber])
                .Must(FightHelpers.HaveUniqueFighters)
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsUniqueFighters)]);

            RuleForEach(x => x.Teams)
                .Must(team => team.Fighters.Count >= FightsConsts.MinTeamFighters)
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsMinTeamFighters), FightsConsts.MinTeamFighters])
                .Must(team => team.Fighters.Count <= FightsConsts.MaxTeamFighters)
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsMaxTeamFighters), FightsConsts.MaxTeamFighters]);

            When(x => !string.IsNullOrWhiteSpace(x.VideoUrl), () =>
            {
                RuleFor(x => x.VideoUrl)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.VideoUrlNotEmpty)])
                    .Matches(ValidationConsts.YoutubeVideoUrlRegex)
                    .WithMessage(x => localizer[nameof(ValidationMessageString.VideoUrlMatchesRegex)]);
            });

            RuleFor(x => x.TypeId)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.TypeNotEmpty)]);
        }
    }
}