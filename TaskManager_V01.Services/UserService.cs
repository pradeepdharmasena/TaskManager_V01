using AutoMapper;
using TaskManager_V01.Dtos;
using TaskManager_V01.Models;
using TaskManager_V01.Repositories;

namespace TaskManager_V01.Services
{
    public class UserService(IUserRepository userAccountRepository, IMapper mapper ) : IUserService
    {
        public UserOutDTO? Create(UserRegisterDTO userAccountInDTO)
        {
            User user = mapper.Map<User>(userAccountInDTO);
            User? savedUser = userAccountRepository.Create(user);
            return mapper.Map<UserOutDTO>(savedUser);
        }

        public UserOutDTO? Delete(UserDto userAccountDto)
        {
            User? userAccount = userAccountRepository.GetByEmail(userAccountDto.Email);
            if (userAccount == null)
            {
                return null;
            }
            return mapper.Map<UserOutDTO>(userAccountRepository.Delete(userAccount));
           
        }

        public UserOutDTO? GetByEmail(string email)
        {
            return mapper.Map<UserOutDTO>(userAccountRepository.GetByEmail(email));
        }

        public UserOutDTO? GetByEmailAndPassword(string email, string password)
        {
            return mapper.Map<UserOutDTO>(userAccountRepository.GetByEmailAndPassword(email, password));
        }

        public UserOutDTO? Update(UserDto userAccountUpdateDto)
        {
            User? userAccount = userAccountRepository.GetByEmail(userAccountUpdateDto.Email);
            return mapper.Map<UserOutDTO>(userAccount);
        }
    }
}
