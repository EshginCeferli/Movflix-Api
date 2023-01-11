namespace Service.Services.DTOs.Blog
{
    public class BlogUpdateDto
    {
        public string Name { get; set; }
        public byte[]? Photo { get; set; }

        public string? Description { get; set; }
        public string? Intro { get; set; }
    }
}
