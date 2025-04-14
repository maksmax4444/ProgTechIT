using LibraryDataLayer;

namespace LibraryLogicLayer
{
    public abstract class DataService
    {
        DataRepository dataRepository;

        public void InitDataRepository()
        {
            dataRepository = new DataRepository();
            dataRepository.InitRepository();
        }

        public void BorrowCatalog(int StateId, int UserId)
        {
            dataRepository.BorrowCatalog(StateId, UserId);
        }

        public void ReturnCatalog(int StateId, int UserId)
        {
            dataRepository.ReturnCatalog(StateId, UserId);
        }

        public void DestoryCatalog(int StateId)
        {
            dataRepository.DestoryCatalog(StateId);
        }

        public void AddCatalog(int StateId)
        {
            dataRepository.AddCatalog(StateId);
        }
    }
}
