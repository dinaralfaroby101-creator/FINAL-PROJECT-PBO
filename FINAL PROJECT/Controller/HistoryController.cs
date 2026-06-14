using FINAL_PROJECT.Models;
using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class HistoryController
    {
        private readonly HistoryService
            _service;

        public HistoryController()
        {
            _service =
                new HistoryService();
        }

        public List<HistoryItem>
            GetHistoryData()
        {
            return _service
                .GetHistoryData();
        }
    }
}