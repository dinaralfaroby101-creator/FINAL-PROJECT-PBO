using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepository;

        public AuthService()
        {
            _userRepository = new UserRepository();
        }

        public User Login(
            string username,
            string password)
        {
            return _userRepository.Login(
                username,
                password);
        }
    }
}