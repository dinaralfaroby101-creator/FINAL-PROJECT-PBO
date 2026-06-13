using FINAL_PROJECT.Models;
using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class DashboardController
    {
        private readonly DashboardService
            _service;

        public DashboardController()
        {
            _service =
                new DashboardService();
        }

        public DashboardSummary
            GetDashboardSummary()
        {
            return _service
                .GetDashboardSummary();
        }


        public AreaSummary
            GetAreaSummary(
                string area)
        {
            return _service
                .GetAreaSummary(area);
        }


    }
}