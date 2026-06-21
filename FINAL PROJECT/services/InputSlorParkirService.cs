using FINAL_PROJECT.Repositories;

namespace FINAL_PROJECT.Services
{
    public class SlotParkirService
    {
        private readonly
            SlotParkirRepository _repository;

        public SlotParkirService()
        {
            _repository = 
                new SlotParkirRepository();
        }

        public bool Insert(
            string kode,
            string status)
        {
            return _repository
                .Insert(
                    kode,
                    status);
        }

        public bool Update(
            int id,
            string kode,
            string status)
        {
            return _repository
                .Update(
                    id,
                    kode,
                    status);
        }
    }
}