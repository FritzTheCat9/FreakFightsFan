namespace FreakFightsFan.Api.Data.Entities
{
    public class Fighter : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

        public Image? Image { get; set; }
    }
}
