using TaskManager_V01.Dtos;

namespace TaskManager_V01.Services
{
    public interface IUserService
    {
        public UserOutDTO? Create(UserRegisterDTO userAccountInDTO);
        public UserOutDTO? Update(UserDto userAccountUpdateDto);
        public UserOutDTO? Delete(UserDto userAccountDto);
        public UserOutDTO? GetByEmailAndPassword(string email, string password);
        public UserOutDTO? GetByEmail(string email);
    }
}
