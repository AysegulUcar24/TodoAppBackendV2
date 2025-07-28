using System.Linq;
using TodoApi.Entities;

namespace TodoApi.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User GetByEmail(string email) => _context.Kullanicilar.FirstOrDefault(u => u.Email == email);

        public void Add(User user)
        {
            _context.Kullanicilar.Add(user);
            _context.SaveChanges();
        }
    }
}