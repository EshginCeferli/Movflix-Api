using Service.Services.DTOs.Banner;
using Service.Services.DTOs.Pricing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IPricingService
    {
        Task CreateAsync(PricingCreateDto pricingCreateDto);
        Task<List<PricingListDto>> GetAllAsync();
        Task<PricingGetDto> GetAsync(int id);
        Task UpdateAsync(int id, PricingUpdateDto pricingUpdateDto);
        Task DeleteAsync(int id);
    }
}
