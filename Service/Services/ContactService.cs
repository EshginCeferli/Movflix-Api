using AutoMapper;
using Repository.Interfaces;
using Service.Services.DTOs.Blog;
using Service.Services.DTOs.Contact;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repo;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<ContactListDto>> GetAllAsync()
        {
            return _mapper.Map<List<ContactListDto>>(await _repo.GetAllAsync());

        }

        public async Task<ContactGetDto> GetAsync(int id)
        {
           return _mapper.Map<ContactGetDto>(await _repo.GetAsync(id));
        }

        public async Task UpdateAsync(int id, ContactUpdateDto contactUpdateDto)
        {
            var dbContact = await _repo.GetAsync(id);

            _mapper.Map(contactUpdateDto, dbContact);

            await _repo.UpdateAsync(dbContact);
        }
    }
}
