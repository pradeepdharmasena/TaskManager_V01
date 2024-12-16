using TaskManager_V01.DataAccess;
using TaskManager_V01.Models;

namespace TaskManager_V01.Repositories
{
    public class UserAccountRepository(AppDBContext appDBContext) : IUserAccountRepository
    {
        public UserAccount? Create(UserAccount user)
        {
            try
            {
                var savedUser = appDBContext.UserAccounts.Add(user);
                appDBContext.SaveChanges();
                return savedUser.Entity;
            }catch (Exception)
            {
                return null;
            }
        }

        public UserAccount? Delete(UserAccount user)
        {
            try
            {
                var deletedUser = appDBContext.UserAccounts.Remove(user);
                appDBContext.SaveChanges();
                return deletedUser.Entity;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public UserAccount? GetByEmail(string email)
        {
            try
            {
                var user = appDBContext.UserAccounts.FirstOrDefault(x => x.Email == email);
                return user;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public UserAccount? GetByID(int id)
        {
            try
            {
                UserAccount? result = appDBContext.UserAccounts.FirstOrDefault(x => x.AccountID == id);
                return result;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public UserAccount? GetByEmailAndPassword(string email, string password)
        {
            try
            {
                UserAccount? result = appDBContext.UserAccounts.FirstOrDefault(x => x.Email == email && x.Password == password);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public UserAccount? Update(UserAccount user)
        {
            try
            {
                var updatedUser = appDBContext.UserAccounts.Update(user);
                appDBContext.SaveChanges();
                return updatedUser.Entity;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
