using FluentValidation;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Blazor.Pages.Tests
{
    public static class CreateTest
    {
        public class Command
        {
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public int? DictionaryItemId { get; set; }
            public FighterDto Fighter { get; set; }
            public int Number { get; set; }
            public string ImageBase64 { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();

                RuleFor(x => x.Date)
                    .NotEmpty();

                RuleFor(x => x.DictionaryItemId)
                    .NotEmpty();

                RuleFor(x => x.Fighter)
                    .NotEmpty();

                RuleFor(x => x.Number)
                    .NotEmpty();

                //RuleFor(x => x.ImageBase64)
                //    .NotEmpty();
            }
        }
    }
}
