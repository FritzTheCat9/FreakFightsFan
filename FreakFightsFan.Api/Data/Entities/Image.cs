namespace FreakFightsFan.Api.Data.Entities
{
    public class Image : Entity
    {
        public byte[] Data { get; set; }
        public string ContentType { get; set; }
    }
}
