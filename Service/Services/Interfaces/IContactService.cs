using Service.Services.DTOs.Blog;
using Service.Services.DTOs.Comment;
using Service.Services.DTOs.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IContactService
    {
        Task UpdateAsync(int id, ContactUpdateDto contactUpdateDto);
        Task<List<ContactListDto>> GetAllAsync();
        Task<ContactGetDto> GetAsync(int id);

    }
}
