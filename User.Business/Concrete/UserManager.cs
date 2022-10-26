using User.DataAccess.Abstract;
using User.Business.Abstract;
using User.Entities;

namespace User.Business.Concrete;

public class UserManager:IUserService
{
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public List<Entities.User> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public Entities.User GetUserById(int id)
    {
        return _userRepository.GetUserById(id);
    }

    public Entities.User CreateUser(Entities.User user)
    {
        return _userRepository.CreateUser(user);
    }

    public Entities.User UpdateUser(Entities.User user)
    {
        return _userRepository.UpdateUser(user);
    }

    public void DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
    }
}