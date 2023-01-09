using Domain.Entities;
using Repository.Data;
using Repository.Interfaces;


namespace Repository
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(AppDbContext context) : base(context) { }

    }
}
