using TaskManager_V01.DataAccess;
using TaskManager_V01.Models;

namespace TaskManager_V01.Repositories
{
    public class UserAccountRepository(AppDBContext appDBContext) : IUserAccountRepository
    {
        public UserAccount Create(UserAccount user)
        {
            var savedUser =  appDBContext.UserAccounts.Add(user);
            appDBContext.SaveChanges();
            return savedUser.Entity;
        }

        public UserAccount Delete()
        {
            throw new NotImplementedException();
        }

        public UserAccount? GetByEmail(string email)
        {
            var user = appDBContext.UserAccounts.FirstOrDefault(x => x.Email == email);
            return user;
        }

        public UserAccount Update(UserAccount user)
        {
            var updatedUser = appDBContext.UserAccounts.Update(user);
            appDBContext.SaveChanges();
            return updatedUser.Entity;
        }
    }
}
