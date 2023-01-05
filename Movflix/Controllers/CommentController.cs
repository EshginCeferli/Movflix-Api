using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Comment;
using Service.Services.Interfaces;

namespace Movflix.Controllers
{
    public class CommentController : AppController
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CommentCreateDto commentCreateDto)
        {
            await _commentService.CreateAsync(commentCreateDto);

            return Ok();

        }
    }
}
