using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzValidationMessage<T>
{
    [Parameter] public Expression<Func<T>> For { get; set; }
}