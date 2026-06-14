using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class FinanceReportService
    {
        private readonly FinanceReportRepository
            _repository =
            new FinanceReportRepository();

        public FinanceReportModel GetStatistic()
        {
            return _repository.GetStatistic();
        }





        public List<PendapatanChartModel>
    GetChartPendapatan(
        int jumlahHari)
        {
            return
                _repository.GetChartPendapatan(
                    jumlahHari);
        }


        public List<KendaraanChartModel>
    GetDataKendaraan(
        int jumlahHari)
        {
            return
                _repository.GetDataKendaraan(
                    jumlahHari);
        }

        public List<MetodePembayaranChartModel>
            GetMetodePembayaran(
                int jumlahHari)
        {
            return
                _repository.GetMetodePembayaran(
                    jumlahHari);
        }
    }
}