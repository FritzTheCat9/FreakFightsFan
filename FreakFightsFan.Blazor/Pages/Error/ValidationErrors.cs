namespace FreakFightsFan.Blazor.Pages.Error
{
    public class ValidationErrors
    {
        public Dictionary<string, List<string>> Errors { get; set; } = [];

        public Func<object, string, List<string>> Validate => (model, propertyName) =>
        {
            // TODO: front validation on model

            if (!Errors.ContainsKey(propertyName))
                Errors.Add(propertyName, []);

            return Errors[propertyName];
        };
    }
}
