using FINAL_PROJECT.Models;
using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class MonitoringController
    {
        private readonly MonitoringService
            _service;

        public MonitoringController()
        {
            _service =
                new MonitoringService();
        }

        public List<MonitoringSlot>
            GetMonitoringSlots()
        {
            return _service
                .GetMonitoringSlots();
        }

        public MonitoringArea
            GetAreaStatistic(
                string area)
        {
            return _service
                .GetAreaStatistic(area);
        }
    }
}