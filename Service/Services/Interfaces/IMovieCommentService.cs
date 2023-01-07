using Service.Services.DTOs.Comment;
using Service.Services.DTOs.MovieComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IMovieCommentService
    {
        Task CreateAsync(MovieCommentCreateDto commentCreateDto);
    }
}
