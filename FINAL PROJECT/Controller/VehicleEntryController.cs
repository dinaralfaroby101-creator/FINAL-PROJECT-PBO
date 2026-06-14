using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class VehicleEntryController
    {
        private readonly VehicleEntryService
            _service;

        public VehicleEntryController()
        {
            _service =
                new VehicleEntryService();
        }

        public string GetAvailableSlot(
            string area)
        {
            return _service
                .GetAvailableSlot(area);
        }



        public int GetOrCreateMerk(
    string namaMerk)
        {
            return _service
                .GetOrCreateMerk(
                    namaMerk);
        }



        public int GetOrCreateVehicle(
    string platNomor,
    string jenisKendaraan,
    int idMerk)
        {
            return _service
                .GetOrCreateVehicle(
                    platNomor,
                    jenisKendaraan,
                    idMerk);
        }



        public void CreateTransaction(
    string platNomor,
    string kodeSlot,
    int idPetugas)
        {
            _service.CreateTransaction(
                platNomor,
                kodeSlot,
                idPetugas);
        }
    }
}