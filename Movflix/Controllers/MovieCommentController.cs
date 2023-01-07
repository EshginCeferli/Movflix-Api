using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Comment;
using Service.Services.DTOs.MovieComment;
using Service.Services.Interfaces;

namespace Movflix.Controllers
{
    public class MovieCommentController : AppController
    {
        private readonly IMovieCommentService _commentService;

        public MovieCommentController(IMovieCommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MovieCommentCreateDto commentCreateDto)
        {
            await _commentService.CreateAsync(commentCreateDto);

            return Ok();

        }
    }
}
