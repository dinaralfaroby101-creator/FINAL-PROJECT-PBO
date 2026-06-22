using FINAL_PROJECT.Models;
using FINAL_PROJECT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Controller
{
    internal class UserController
    {
        private readonly UserServices
        _service =
        new UserServices();

        public void DeleteUser(int id)
        {
            _service.DeleteUser(id);
        }


        public List<UserModels>
        Search(string keyword)
        {
            return _service.Search(keyword);
        }




        public List<UserModels>
            GetByRole(string role)
        {
            return _service
                .GetByRole(role);
        }




        public UserStatisticModel
            GetStatistic()
        {
            return _service
                .GetStatistic();
        }


        
    }
}
