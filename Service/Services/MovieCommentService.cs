using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using Service.Services.DTOs.Comment;
using Service.Services.DTOs.MovieComment;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MovieCommentService : IMovieCommentService
    {
        private readonly IMovieCommentRepository _repo;
        private readonly IMapper _mapper;

        public MovieCommentService(IMovieCommentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(MovieCommentCreateDto commentCreateDto)
        {
            var mappedComment = _mapper.Map<MovieComment>(commentCreateDto);
            await _repo.CreateAsync(mappedComment);
        }
    }
}
