using TaskManager_V01.DataAccess;
using TaskManager_V01.Models;

namespace TaskManager_V01.Repositories
{
    public class UserRepository(AppDBContext appDBContext) : IUserRepository
    {
        public User? Create(User user)
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

        public User? Delete(User user)
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

        public User? GetByEmail(string email)
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

        public User? GetByID(string id)
        {
            try
            {
                User? result = appDBContext.UserAccounts.FirstOrDefault(x => x.UserId == id);
                return result;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public User? GetByEmailAndPassword(string email, string password)
        {
            try
            {
                User? result = appDBContext.UserAccounts.FirstOrDefault(x => x.Email == email && x.Password == password);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public User? Update(User user)
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
