using FINAL_PROJECT.Models;
using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class VehicleExitController
    {
        private readonly VehicleExitService
            _service;

        public VehicleExitController()
        {
            _service =
                new VehicleExitService();
        }

        public VehicleExitInfo
            GetVehicleInfo(
                string platNomor)
        {
            return _service
                .GetVehicleInfo(
                    platNomor);
        }



        public decimal ExitVehicle(
            int idTransaksi,
            int idMetodePembayaran)
        {
            return _service
                .ExitVehicle(
                    idTransaksi,
                    idMetodePembayaran);
        }
    }
}   