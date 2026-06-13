using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class MonitoringService
    {
        private readonly MonitoringRepository
            _repository;

        public MonitoringService()
        {
            _repository =
                new MonitoringRepository();
        }

        public List<MonitoringSlot>
            GetMonitoringSlots()
        {
            return _repository
                .GetMonitoringSlots();
        }

        public MonitoringArea
            GetAreaStatistic(string area)
        {
            return _repository
                .GetAreaStatistic(area);
        }

        
    }
}