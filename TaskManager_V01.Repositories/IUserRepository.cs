using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_V01.Models;

namespace TaskManager_V01.Repositories
{
    public interface IUserRepository
    {
        public User? GetByEmailAndPassword(string Email, string password);
        public User? GetByEmail(string Email);
        public User? GetByID(string id);
        public User? Create(User user);
        public User? Update(User user);
        public User? Delete(User user);

    }
}
