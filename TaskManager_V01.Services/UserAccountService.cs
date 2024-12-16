using AutoMapper;
using TaskManager_V01.Dtos;
using TaskManager_V01.Models;
using TaskManager_V01.Repositories;

namespace TaskManager_V01.Services
{
    public class UserAccountService(IUserAccountRepository userAccountRepository, IMapper mapper ) : IUserAccountService
    {
        public UserAccountOutDTO? Create(UserAccountInDTO userAccountInDTO)
        {
            UserAccount user = mapper.Map<UserAccount>(userAccountInDTO);
            UserAccount? savedUser = userAccountRepository.Create(user);
            return mapper.Map<UserAccountOutDTO>(savedUser);
        }

        public UserAccountOutDTO? Delete(UserAccountDto userAccountDto)
        {
            UserAccount? userAccount = userAccountRepository.GetByEmail(userAccountDto.Email);
            if (userAccount == null)
            {
                return null;
            }
            return mapper.Map<UserAccountOutDTO>(userAccountRepository.Delete(userAccount));
           
        }

        public UserAccountOutDTO? GetByEmail(string email)
        {
            return mapper.Map<UserAccountOutDTO>(userAccountRepository.GetByEmail(email));
        }

        public UserAccountOutDTO? GetByEmailAndPassword(string email, string password)
        {
            return mapper.Map<UserAccountOutDTO>(userAccountRepository.GetByEmailAndPassword(email, password));
        }

        public UserAccountOutDTO? Update(UserAccountDto userAccountUpdateDto)
        {
            UserAccount? userAccount = userAccountRepository.GetByEmail(userAccountUpdateDto.Email);
            return mapper.Map<UserAccountOutDTO>(userAccount);
        }
    }
}
