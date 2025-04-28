using LibraryDataLayer;

namespace LibraryLogicLayer
{
    internal class DataService: DataServiceI
    {
        static DataContextI data = default(DataContextI);
        static DataRepository dataRepository = new DataRepository(data);

        public override void BorrowCatalog(int StateId, int UserId)
        {
            dataRepository.BorrowCatalog(StateId, UserId);
        }

        public override void ReturnCatalog(int StateId, int UserId)
        {
            dataRepository.ReturnCatalog(StateId, UserId);
        }

        public override void DestoryCatalog(int StateId)
        {
            dataRepository.DestroyCatalog(StateId);
        }

        public override void AddCatalog(int StateId)
        {
            dataRepository.AddCatalog(StateId);
        }
    }
}
