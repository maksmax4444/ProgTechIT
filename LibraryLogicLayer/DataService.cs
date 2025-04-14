using LibraryDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class DataService: DataServiceI
    {
        DataRepository dataRepository = new DataRepository(new DataContext());

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
