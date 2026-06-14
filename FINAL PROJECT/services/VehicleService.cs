using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class VehicleService
    {
        private readonly VehicleRepository
            _repository;

        public VehicleService()
        {
            _repository =
                new VehicleRepository();
        }

        public List<VehicleDataModel>
            GetAllVehicle()
        {
            return _repository
                .GetAllVehicle();
        }


        public int GetTotalVehicle()
        {
            return _repository
                .GetTotalVehicle();
        }

        public int GetTotalMotor()
        {
            return _repository
                .GetTotalMotor();
        }

        public int GetTotalMobil()
        {
            return _repository
                .GetTotalMobil();
        }

        public int GetTotalBus()
        {
            return _repository
                .GetTotalBus();
        }



        public List<VehicleDataModel>
    SearchVehicle(string keyword)
        {
            return _repository
                .SearchVehicle(keyword);
        }
    }
}