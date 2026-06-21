using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class ParkingDataService
    {
        private readonly
            ParkingDataRepository
            _repository;

        public ParkingDataService()
        {
            _repository =
                new ParkingDataRepository();
        }

        public List<ParkingSlotModels>
            GetAll()
        {
            return _repository
                .GetAll();
        }

        public ParkingStatisticModel
        GetStatistic()
        {
            return _repository
                .GetStatistic();
        }

        public List<ParkingSlotModels>
        GetByArea(string area)
        {
            return _repository
                .GetByArea(area);
        }
    }
}