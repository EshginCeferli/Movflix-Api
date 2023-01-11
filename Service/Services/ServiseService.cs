using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using Service.Services.DTOs.Service;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ServiseService : IServiseService
    {
        private readonly IServiceRepository _repo;
        private readonly IMapper _mapper;

        public ServiseService(IServiceRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(ServiceCreateDto serviceCreateDto)
        {
            var mappedData = _mapper.Map<Servise>(serviceCreateDto);
            await _repo.CreateAsync(mappedData);
        }

        public async Task DeleteAsync(int id)
        {
            var service = await _repo.GetAsync(id);

            await _repo.DeleteAsync(service);
        }

        public async Task<List<ServiceListDto>> GetAllAsync()
        {
            return _mapper.Map<List<ServiceListDto>>(await _repo.GetAllAsync());
        }

        public async Task<ServiceGetDto> GetAsync(int id)
        {
            return _mapper.Map<ServiceGetDto>(await _repo.GetAsync(id));
        }

        public async Task UpdateAsync(int id, ServiceUpdateDto serviceUpdateDto)
        {
            var dbService = await _repo.GetAsync(id);

            _mapper.Map(serviceUpdateDto, dbService);

            await _repo.UpdateAsync(dbService);
        }

    }
}
