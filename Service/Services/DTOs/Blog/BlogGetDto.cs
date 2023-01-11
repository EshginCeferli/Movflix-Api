using Service.Services.DTOs.BlogImage;
using Service.Services.DTOs.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.DTOs.Blog
{
    public class BlogGetDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Intro { get; set; }
        public string? By { get; set; }
        public string? CreateDate { get; set; }
        public byte[]? Photo { get; set; }

        //public List<BlogImageListDto>? BlogImages { get; set; }
        public List<CommentListDto>? Comments { get; set; }
    }
}
