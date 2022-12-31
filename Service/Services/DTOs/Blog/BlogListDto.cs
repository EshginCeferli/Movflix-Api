﻿using Service.Services.DTOs.BlogImage;

namespace Service.Services.DTOs.Blog
{
    public class BlogListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? By { get; set; }
        public List<BlogImageListDto>? BlogImages { get; set; }
        public string CreateDate { get; set; }
    }
}
