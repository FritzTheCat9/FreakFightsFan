namespace FreakFightsFan.Blazor.Pages.Error
{
    public class ValidationErrors
    {
        public Dictionary<string, List<string>> Errors { get; set; } = [];

        public Func<object, string, List<string>> Validate => (model, propertyName) =>
        {
            if (!Errors.ContainsKey(propertyName))
                Errors.Add(propertyName, new List<string>());

            return Errors[propertyName];
        };
    }
}
