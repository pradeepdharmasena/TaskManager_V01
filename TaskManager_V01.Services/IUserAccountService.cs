using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_V01.Dtos;

namespace TaskManager_V01.Services
{
    public interface IUserAccountService
    {
        public UserAccountOutDTO Create(UserAccountInDTO userAccountInDTO);
        public UserAccountOutDTO Update(UserAccountInDTO userAccountInDTO);
        public UserAccountOutDTO Delete(int id);
        public UserAccountOutDTO Get(int id);
        public UserAccountOutDTO GetByEmail(string email);
    }
}
