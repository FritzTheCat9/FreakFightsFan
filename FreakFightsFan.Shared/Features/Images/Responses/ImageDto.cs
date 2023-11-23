namespace FreakFightsFan.Shared.Features.Images.Responses
{
    public class ImageDto
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public string ImageBase64 { get; set; }
    }
}

