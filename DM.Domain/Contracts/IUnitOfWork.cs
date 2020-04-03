using System;
using System.Collections.Generic;
using System.Text;

namespace DM.Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
