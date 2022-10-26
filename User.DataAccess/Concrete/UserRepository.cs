using Microsoft.EntityFrameworkCore;
using User.DataAccess.Abstract;

namespace User.DataAccess.Concrete;

public class UserRepository:IUserRepository
{

    public List<Entities.User> GetAllUsers()
    {
        using (var userDbContext = new UserDbContext())
        {
            return userDbContext.Users.ToList();
        }
    }

    public Entities.User GetUserById(int id)
    {
        using (var userDbContext = new UserDbContext())
        {
            return userDbContext.Users.Find(id);
        }
    }

    public Entities.User CreateUser(Entities.User user)
    {
        using (var userDbContext = new UserDbContext())
        {
            userDbContext.Users.Add(user);
            userDbContext.SaveChanges();
            return user;
        }
    }

    public Entities.User UpdateUser(Entities.User user)
    {
        using (var userDbContext = new UserDbContext())
        {
            userDbContext.Users.Update(user);
            userDbContext.SaveChanges();
            return user;
        }
    }

    public void DeleteUser(int id)
    {
        using (var userDbContext = new UserDbContext())
        {
            Entities.User user = userDbContext.Users.Find(id);
            userDbContext.Users.Remove(user);
            userDbContext.SaveChanges();
        }
    }
}