using FluentValidation;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Fights.Commands;

public static class CreateFight
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
        public Validator(IStringLocalizer<ValidationMessage> localizer)
        {
            RuleFor(x => x.Teams)
                .NotEmpty()
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsNotEmpty)])
                .Must(teams => teams.Count >= FightsConsts.MinTeamsNumber)
                .WithMessage(x
                    => localizer[nameof(ValidationMessageString.TeamsMinNumber), FightsConsts.MinTeamsNumber])
                .Must(teams => teams.Count <= FightsConsts.MaxTeamsNumber)
                .WithMessage(x
                    => localizer[nameof(ValidationMessageString.TeamsMaxNumber), FightsConsts.MaxTeamsNumber])
                .Must(FightHelpers.HaveUniqueFighters)
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsUniqueFighters)]);

            RuleForEach(x => x.Teams)
                .Must(team => team.Fighters.Count >= FightsConsts.MinTeamFighters)
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsMinTeamFighters),
                    FightsConsts.MinTeamFighters])
                .Must(team => team.Fighters.Count <= FightsConsts.MaxTeamFighters)
                .WithMessage(x => localizer[nameof(ValidationMessageString.TeamsMaxTeamFighters),
                    FightsConsts.MaxTeamFighters]);

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