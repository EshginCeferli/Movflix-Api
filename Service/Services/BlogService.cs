using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using Service.Services.DTOs.Blog;

using Service.Services.Interfaces;

namespace Service.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _repo;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        public async Task CreateAsync(BlogCreateDto blogCreateDto)
        {
            var mappedData = _mapper.Map<Blog>(blogCreateDto);
            await _repo.CreateAsync(mappedData);
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _repo.GetAsync(id);

            await _repo.DeleteAsync(product);
        }

        public async Task<List<BlogListDto>> GetAllAsync()
        {
            return _mapper.Map<List<BlogListDto>>(await _repo.GetAllAsync());
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return (await _repo.GetAsync(id));
        }

        public async Task SoftDeleteAsync(int id)
        {
            var blog = await _repo.GetAsync(id);

            await _repo.SoftDeleteAsync(blog);


        }

        public async Task UpdateAsync(int id, BlogUpdateDto blogUpdateDto)
        {
            var dbBlog = await _repo.GetAsync(id);

            _mapper.Map(blogUpdateDto, dbBlog);

            await _repo.UpdateAsync(dbBlog);
        }
    }
}
