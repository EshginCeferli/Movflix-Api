using AutoMapper;
using Domain.Entities;
using Repository.Interfaces;
using Service.Services.DTOs.Banner;
using Service.Services.DTOs.Comment;
using Service.Services.DTOs.Movflix;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BannerService : IBannerService
    {
        private readonly IBannerRepository _repo;
        private readonly IMapper _mapper;

        public BannerService(IBannerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(BannerCreateDto bannerCreateDto)
        {
            var mappedData = _mapper.Map<Banner>(bannerCreateDto);
            await _repo.CreateAsync(mappedData);
        }

        public async Task DeleteAsync(int id)
        {
            var banner = await _repo.GetAsync(id);

            await _repo.DeleteAsync(banner);
        }

        public async Task<List<BannerListDto>> GetAllAsync()
        {
            return _mapper.Map<List<BannerListDto>>(await _repo.GetAllAsync());
        }

        public async Task<BannerGetDto> GetAsync(int id)
        {
           return _mapper.Map<BannerGetDto>(await _repo.GetAsync(id));
        }

        public async Task UpdateAsync(int id, BannerUpdateDto bannerUpdateDto)
        {
            var dbBanner = await _repo.GetAsync(id);

            _mapper.Map(bannerUpdateDto, dbBanner);

            await _repo.UpdateAsync(dbBanner);
        }
    }
}
