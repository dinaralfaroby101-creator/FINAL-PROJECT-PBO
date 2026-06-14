using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class HistoryService
    {
        private readonly HistoryRepository
            _repository;

        public HistoryService()
        {
            _repository =
                new HistoryRepository();
        }

        public List<HistoryItem>
            GetHistoryData()
        {
            return _repository
                .GetHistoryData();
        }
    }

}