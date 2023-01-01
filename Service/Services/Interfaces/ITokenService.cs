using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateJwtToken(string email, string name, List<string> roles);
    }
}
