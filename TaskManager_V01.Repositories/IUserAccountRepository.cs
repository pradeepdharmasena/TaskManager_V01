using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_V01.Models;

namespace TaskManager_V01.Repositories
{
    public interface IUserAccountRepository
    {
        public UserAccount? GetByEmail(string Email);
        public UserAccount Create(UserAccount user);
        public UserAccount Update(UserAccount user);
        public UserAccount Delete();

    }
}
