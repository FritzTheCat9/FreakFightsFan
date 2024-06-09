using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components
{
    public abstract class FritzFormInputBase<T> : ComponentBase
    {
        [CascadingParameter] private EditContext EditContext { get; set; }

        [Parameter] public Expression<Func<T>> For { get; set; }

        private FieldIdentifier _fieldIdentifier;

        protected override void OnParametersSet()
        {
            if (For is not null)
                _fieldIdentifier = FieldIdentifier.Create(For);
        }

        internal void ValidateField()
        {
            if (!string.IsNullOrEmpty(_fieldIdentifier.FieldName))
            {
                EditContext?.NotifyFieldChanged(_fieldIdentifier);
            }
        }
    }
}
