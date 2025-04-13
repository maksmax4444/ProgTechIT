using LibraryDataLayer;

namespace LibraryLogicLayer
{
    public class DataService
    {
        DataRepository dataRepository;
        int currentUser;
        int currentState;

        public void SetCurrentUser(int id)
        {
            currentUser = id;
        }

        public void SetCurrentState(int id)
        {
            currentState = id;
        }

        void BorrowCatalog()
        {
            dataRepository.BorrowCatalog(currentState, currentUser);
        }

        void ReturnCatalog()
        {
            dataRepository.ReturnCatalog(currentState, currentUser);
        }

        void DestoryCatalog()
        {
            dataRepository.DestoryCatalog(currentState);
        }

        void AddCatalog()
        {
            dataRepository.AddCatalog(currentState);
        }
    }
}
