using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class PenitipanService
    {
        private readonly
            PenitipanRepository
            _repository =
            new PenitipanRepository();

        public List<PenitipanModel>
            GetAll()
        {
            return _repository.GetAll();
        }

        public PenitipanStatisticModel
    GetStatistic()
        {
            return _repository
                .GetStatistic();
        }


        public List<PenitipanModel>
    Search(string keyword)
        {
            return _repository
                .Search(keyword);
        }


        public List<PenitipanModel>
    GetHistory()
        {
            return _repository
                .GetHistory();
        }



        public void TambahPenitipan(
    string namaBarang,
    string kategori,
    string pemilik,
    int jumlah)
        {
            _repository.TambahPenitipan(
                namaBarang,
                kategori,
                pemilik,
                jumlah);
        }




        public void AmbilBarang(
    int idPenitipan)
        {
            _repository.AmbilBarang(
                idPenitipan);
        }



        public void DeletePenitipan(
    int idPenitipan)
        {
            _repository.DeletePenitipan(
                idPenitipan);
        }
    }
}