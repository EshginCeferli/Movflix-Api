using Service.Services.DTOs.BlogImage;
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
        public string? By { get; set; }
        public string? CreateDate { get; set; }

        public List<BlogImageListDto>? BlogImages { get; set; }
    }
}
