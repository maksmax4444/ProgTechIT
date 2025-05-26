using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryLogicLayer;

namespace PresentationLayer.ViewModel
{
    internal class CatalogViewModelCollection : PropertyChange
    {
        private int _catalogId;
        private string _title;
        private string _author;
        private int _nrOfPages;
        private const string connectionString = "";
        private IDataService ids = IDataService.CreateNewDataService(connectionString);
        private CatalogViewModel _detail;
        public ObservableCollection<CatalogViewModel> Catalogs { get; set; }
        public ICommand Add { get; }
        public ICommand Delete { get; }
        public ICommand Update { get; }
        public ICommand Load { get; }
        public int CatalogId
        {
            get
            {
                return _catalogId;
            }

            set
            {
                _catalogId = value;
                OnPropertyChanged(nameof(CatalogId));
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }
        public int NrOfPages
        {
            get
            {
                return _nrOfPages;
            }

            set
            {
                _nrOfPages = value;
                OnPropertyChanged(nameof(NrOfPages));
            }
        }
        public CatalogViewModel Detail
        {
            get
            {
                return _detail;
            }

            set
            {
                _detail = value; 
                OnPropertyChanged(nameof(Detail));
                CatalogId = value.CatalogId;
                Title = value.Title;
                Author = value.Author;
                NrOfPages = value.NrOfPages;
            }
        }
        public CatalogViewModelCollection()
        {
            Catalogs = new ObservableCollection<CatalogViewModel> { };
            Add = new RelayCommand(_ => add());
            Delete= new RelayCommand(_ => delete());
            Update = new RelayCommand(_ => update());
        }

        public void add()
        {
            ids.AddCatalog(CatalogId, Title, Author, NrOfPages);
        }

        public void delete()
        {
            ids.RemoveCatalog(CatalogId);
        }

        public void update()
        {
            ids.UpdateCatalog(CatalogId, Title, Author, NrOfPages);
        }

        public void load()
        {
            Catalogs.Clear();
            foreach (var catalog in ids.GetAllCatalog())
            {
                Catalogs.Add(new CatalogViewModel(CatalogId = catalog.id, Title = catalog.title, Author = catalog.author, NrOfPages = catalog.nrOfPages));
            }
        }
    }
}
