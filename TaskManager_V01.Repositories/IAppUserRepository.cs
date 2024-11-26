using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_V01.Models;

namespace TaskManager_V01.Repositories
{
    public interface IAppUserRepository
    {
        public AppUser GetByGuid(Guid AppUserCD);
        public AppUser Create(AppUser user);
        public AppUser Update(AppUser user);
        public AppUser Delete();

    }
}
