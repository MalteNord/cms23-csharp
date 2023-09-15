using System.Linq.Expressions;
using _01_Exersize.Interfaces;
using _01_Exersize.Models;

namespace _01_Exersize.Services;

internal class UserService : IUserService
{

    private List<User> _users = new List<User>();

    public void CreateUser(UserCreateRequest userCreateRequest)
    {
        _users.Add(new User
        {
            Id = Guid.NewGuid(),
            FirstName = userCreateRequest.FirstName,
            LastName = userCreateRequest.LastName,
            Email = userCreateRequest.Email,
        });

        //Lösenordet får vi hantera separat, av säkerhetsskäl...
    }

    public User GetUser(Func<User, bool> expression)
    {

        var user = _users.FirstOrDefault(expression, null!);
        return user;
    }

   // public User GetUser(Expression<Func<User, bool>> expression)
   // {
     //   throw new NotImplementedException();
    //}

    

    public IEnumerable<User> GetUsers()
    {
        return _users;
    }
}

