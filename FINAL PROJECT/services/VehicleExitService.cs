using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class VehicleExitService
    {
        private readonly VehicleExitRepository
            _repository;

        public VehicleExitService()
        {
            _repository =
                new VehicleExitRepository();
        }

        public VehicleExitInfo
            GetVehicleInfo(
                string platNomor)
        {
            return _repository
                .GetVehicleInfo(
                    platNomor);
        }



        public decimal ExitVehicle(
                int idTransaksi,
                int idMetodePembayaran)
        {
            return _repository
                .ExitVehicle(
                    idTransaksi,
                    idMetodePembayaran);
        }
    }
}