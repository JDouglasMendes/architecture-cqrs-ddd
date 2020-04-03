using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace DM.Domain.Contracts
{
    public interface IUser
    {
        string Name { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
