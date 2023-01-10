using Service.Services.DTOs.Banner;
using Service.Services.DTOs.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IBannerService
    {
        Task CreateAsync(BannerCreateDto bannerCreateDto);
        Task<List<BannerListDto>> GetAllAsync();
        Task<BannerGetDto> GetAsync(int id);
        Task UpdateAsync(int id, BannerUpdateDto bannerUpdateDto);
        Task DeleteAsync(int id);

    }
}
