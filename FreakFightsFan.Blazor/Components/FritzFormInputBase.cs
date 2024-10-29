using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components;

public abstract class FritzFormInputBase<T> : ComponentBase
{
    private FieldIdentifier _fieldIdentifier;

    [CascadingParameter] private EditContext EditContext { get; set; }
    [Parameter] public Expression<Func<T>> For { get; set; }

    protected override void OnParametersSet()
    {
        if (For is not null)
        {
            _fieldIdentifier = FieldIdentifier.Create(For);
        }
    }

    internal void ValidateField()
    {
        if (!string.IsNullOrEmpty(_fieldIdentifier.FieldName))
        {
            EditContext?.NotifyFieldChanged(_fieldIdentifier);
        }
    }
}