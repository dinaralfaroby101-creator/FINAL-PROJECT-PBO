using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class VehicleEntryService
    {
        private readonly VehicleEntryRepository
            _repository;

        public VehicleEntryService()
        {
            _repository =
                new VehicleEntryRepository();
        }

        public string GetAvailableSlot(
            string area)
        {
            return _repository
                .GetAvailableSlot(area);
        }



        public int GetOrCreateMerk(
    string namaMerk)
        {
            return _repository
                .GetOrCreateMerk(
                    namaMerk);
        }



        public int GetOrCreateVehicle(
    string platNomor,
    string jenisKendaraan,
    int idMerk)
        {
            return _repository
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
            _repository.CreateTransaction(
                platNomor,
                kodeSlot,
                idPetugas);
        }
    }
}