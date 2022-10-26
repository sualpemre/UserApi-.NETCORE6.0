namespace User.DataAccess.Abstract;

public interface IUserRepository
{
    List<Entities.User> GetAllUsers();
    Entities.User GetUserById(int id);
    Entities.User CreateUser(Entities.User user);
    Entities.User UpdateUser(Entities.User user);
    void DeleteUser(int id);
}