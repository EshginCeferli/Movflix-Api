using Service.Services.DTOs.BlogImage;

namespace Service.Services.DTOs.Blog
{
    public class BlogCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Intro { get; set; }
        public string By { get; set; }
        public byte[] Photo { get; set; }
        //public List<BlogImageListDto>? BlogImages { get; set; }

    }
}
