using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using TaskManager_V01.Dtos;
using TaskManager_V01.Models;
using TaskManager_V01.Repositories;

namespace TaskManager_V01.Services
{
    public class UserAccountService(IUserAccountRepository userAccountRepository, IMapper Mapper ) : IUserAccountService
    {
        public UserAccountOutDTO Create(UserAccountInDTO userAccountInDTO)
        {
            UserAccount user = Mapper.Map<UserAccount>(userAccountInDTO);
            UserAccount? savedUser = userAccountRepository.Create(user);
            if (savedUser == null)
            {
                return new UserAccountOutDTO();
            }
            else
            {
                return Mapper.Map<UserAccountOutDTO>(savedUser);
            }
        }

        public UserAccountOutDTO Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserAccountOutDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public UserAccountOutDTO GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public UserAccountOutDTO Update(UserAccountInDTO userAccountInDTO)
        {
            throw new NotImplementedException();
        }
    }
}
