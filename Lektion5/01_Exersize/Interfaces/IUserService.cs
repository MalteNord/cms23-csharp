using _01_Exersize.Models;
using System.Linq.Expressions;

namespace _01_Exersize.Interfaces;

internal interface IUserService
{
    public void CreateUser(UserCreateRequest userCreateRequest);

    public User GetUser(Func<User, bool> expression);

    //public User GetUser(Expression<Func<User, bool>> expression);

    public IEnumerable<User> GetUsers();
}

