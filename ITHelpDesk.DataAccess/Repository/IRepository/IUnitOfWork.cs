using System;
using System.Collections.Generic;
using System.Text;

namespace ITHelpDesk.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
       
        ISP_Call SP_Call { get; }
        IApplicationUserRepository ApplicationUser { get; }

        void Save();
    }
}
