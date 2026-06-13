using FINAL_PROJECT.Models;
using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class LoginController
    {
        private readonly AuthService _authService;

        public LoginController()
        {
            _authService = new AuthService();
        }

        public User Login(
            string username,
            string password)
        {
            return _authService.Login(
                username,
                password);
        }
    }
}