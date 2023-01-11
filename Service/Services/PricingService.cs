using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using Service.Services.DTOs.Pricing;
using Service.Services.DTOs.Pricing;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PricingService : IPricingService
    {
        private readonly IPricingRepository _repo;
        private readonly IMapper _mapper;

        public PricingService(IPricingRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(PricingCreateDto pricingCreateDto)
        {
            var mappedData = _mapper.Map<Pricing>(pricingCreateDto);
            await _repo.CreateAsync(mappedData);
        }

        public async Task DeleteAsync(int id)
        {
            var pricing = await _repo.GetAsync(id);

            await _repo.DeleteAsync(pricing);
        }

        public async Task<List<PricingListDto>> GetAllAsync()
        {
            return _mapper.Map<List<PricingListDto>>(await _repo.GetAllAsync());
        }

        public async Task<PricingGetDto> GetAsync(int id)
        {
            return _mapper.Map<PricingGetDto>(await _repo.GetAsync(id));
        }

        public async Task UpdateAsync(int id, PricingUpdateDto pricingUpdateDto)
        {
            var dbPricing = await _repo.GetAsync(id);

            _mapper.Map(pricingUpdateDto, dbPricing);

            await _repo.UpdateAsync(dbPricing);
        }
    }
}
