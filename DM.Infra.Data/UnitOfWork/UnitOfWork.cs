using DM.Domain.Contracts;
using DM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DM.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InfraDataContext _context;
        public UnitOfWork(InfraDataContext context) => _context = context;        
        public bool Commit() => _context.SaveChanges() > 0;        
        public void Dispose() => _context.Dispose();        
    }
}
