using FINAL_PROJECT.Models;
using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class ParkingDataController
    {
        private readonly
            ParkingDataService
            _service;

        public ParkingDataController()
        {
            _service =
                new ParkingDataService();
        }

        public List<ParkingSlotModels>
            GetAll()
        {
            return _service
                .GetAll();
        }



        public ParkingStatisticModel
    GetStatistic()
        {
            return _service
                .GetStatistic();
        }



        public List<ParkingSlotModels>
    Search(string keyword)
        {
            return _service
                .Search(keyword);
        }



        public void Delete(int id)
        {
            _service.Delete(id);
        }


        public List<ParkingSlotModels>
    GetByArea(string area)
        {
            return _service
                .GetByArea(area);
        }
    }
}