namespace FreakFightsFan.Shared.Exceptions
{
    public static class ValidationMessages
    {
        public static string NotEmpty(string propertyName)
            => $"{propertyName} should not be empty";
    }
}
