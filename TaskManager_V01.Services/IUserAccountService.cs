using TaskManager_V01.Dtos;

namespace TaskManager_V01.Services
{
    public interface IUserAccountService
    {
        public UserAccountOutDTO? Create(UserAccountInDTO userAccountInDTO);
        public UserAccountOutDTO? Update(UserAccountDto userAccountUpdateDto);
        public UserAccountOutDTO? Delete(UserAccountDto userAccountDto);
        public UserAccountOutDTO? GetByEmailAndPassword(string email, string password);
        public UserAccountOutDTO? GetByEmail(string email);
    }
}
