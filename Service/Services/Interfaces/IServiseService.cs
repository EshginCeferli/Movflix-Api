using Service.Services.DTOs.Banner;
using Service.Services.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IServiseService
    {
        Task CreateAsync(ServiceCreateDto serviceCreateDto);
        Task<List<ServiceListDto>> GetAllAsync();
        Task<ServiceGetDto> GetAsync(int id);
        Task UpdateAsync(int id, ServiceUpdateDto serviceUpdateDto);
        Task DeleteAsync(int id);
    }
}
