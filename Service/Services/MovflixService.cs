using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using Service.Services.DTOs.Movflix;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class MovflixService : IMovflixService
    {
        private readonly IMovflixRepository _repo;
        private readonly IMapper _mapper;

        public MovflixService(IMovflixRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(MovflixCreateDto movflixCreateDto)
        {
            var mappedData = _mapper.Map<Movflix>(movflixCreateDto);
            await _repo.CreateAsync(mappedData);
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _repo.GetAsync(id);

            await _repo.DeleteAsync(product);
        }

        public async Task<List<MovflixListDto>> GetAllAsync()
        {

            return _mapper.Map<List<MovflixListDto>>(await _repo.GetAllAsync());
        }

        public async Task<Movflix> GetByIdAsync(int id)
        {
            return (await _repo.GetAsync(id));
        }

        public async Task SoftDeleteAsync(int id)
        {
            var movflix = await _repo.GetAsync(id);

            await _repo.SoftDeleteAsync(movflix);


        }

        public async Task UpdateAsync(int id, MovflixUpdateDto movflixUpdateDto)
        {
            var dbMovlfix = await _repo.GetAsync(id);

            _mapper.Map(dbMovlfix, movflixUpdateDto);

            await _repo.UpdateAsync(dbMovlfix);
        }
    }
}
