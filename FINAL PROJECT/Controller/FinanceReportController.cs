using FINAL_PROJECT.Models;
using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class FinanceReportController
    {
        private readonly FinanceReportService
            _service =
            new FinanceReportService();

        public FinanceReportModel GetStatistic()
        {
            return _service.GetStatistic();
        }


        public List<PendapatanChartModel>
    GetChartPendapatan(
        int jumlahHari)
        {
            return
                _service.GetChartPendapatan(
                    jumlahHari);
        }


        public List<KendaraanChartModel>
    GetDataKendaraan(
        int jumlahHari)
        {
            return
                _service.GetDataKendaraan(
                    jumlahHari);
        }

        public List<MetodePembayaranChartModel>
            GetMetodePembayaran(
                int jumlahHari)
        {
            return
                _service.GetMetodePembayaran(
                    jumlahHari);
        }




        public int GetJumlahHari(
    string filter)
        {
            switch (filter)
            {
                case "7 Hari":
                    return 7;

                case "1 Bulan":
                    return 30;

                case "3 Bulan":
                    return 90;

                default:
                    return 7;
            }
        }

        


    }
}