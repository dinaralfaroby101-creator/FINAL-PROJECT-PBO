using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class DashboardService
    {
        private readonly DashboardRepository
            _repository;

        public DashboardService()
        {
            _repository =
                new DashboardRepository();
        }

        public DashboardSummary
            GetDashboardSummary()
        {
            return _repository
                .GetDashboardSummary();
        }


        public AreaSummary
             GetAreaSummary(
                string area)
        {
            return _repository
                .GetAreaSummary(area);
        }
    }
}