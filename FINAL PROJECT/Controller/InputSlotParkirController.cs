using FINAL_PROJECT.Services;

namespace FINAL_PROJECT.Controllers
{
    public class SlotParkirController
    {
        private readonly
            SlotParkirService
            _service;

        public SlotParkirController()
        {
            _service =
                new SlotParkirService();
        }

        public bool Insert(
            string kode,
            string status)
        {
            return _service
                .Insert(
                    kode,
                    status);
        }

        public bool Update(
            int id,
            string kode,
            string status)
        {
            return _service
                .Update(
                    id,
                    kode,
                    status);
        }
    }
}