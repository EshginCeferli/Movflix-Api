using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.DTOs.Comment
{
    public class CommentCreateDto
    {
        public string By { get; set; }
        public string Context { get; set; }
        public int BlogId { get; set; }
    }
}
