using TodoApi.Entities;

namespace TodoApi.DataAccess
{
    public interface IUserRepository
    {
        User GetByEmail(string email);
        void Add(User user);
    }
}