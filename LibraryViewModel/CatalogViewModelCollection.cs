using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryModel;

namespace LibraryViewModel
{
    public class CatalogViewModelCollection : PropertyChange
    {
        private int _catalogId;
        private string _title;
        private string _author;
        private int _nrOfPages;
        private static IDataModel ids;
        public CatalogViewModelCollection()
        {
            Catalogs = new ObservableCollection<CatalogViewModel> { };
            Add = new RelayCommand(() => add());
            Delete = new RelayCommand(() => delete());
            Update = new RelayCommand(() => update());
            Load = new RelayCommand(() => load());
            ids = IDataModel.CreateNewDataModel();
        }

        public CatalogViewModelCollection(IDataModel m)
        {
            Catalogs = new ObservableCollection<CatalogViewModel> { };
            Add = new RelayCommand(() => add());
            Delete = new RelayCommand(() => delete());
            Update = new RelayCommand(() => update());
            Load = new RelayCommand(() => load());
            ids = m;
        }

        public CatalogViewModel _detail;
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
                if (value != null)
                {
                    CatalogId = value.CatalogId;
                    Title = value.Title;
                    Author = value.Author;
                    NrOfPages = value.NrOfPages;
                }
            }
        }

        public void add()
        {
            Catalogs.Add(new CatalogViewModel(CatalogId, Title, Author, NrOfPages));
            ids.AddCatalog(CatalogId, Title, Author, NrOfPages);
        }
        public void delete()
        {
            for(int i = Catalogs.Count-1; i>=0; i--)
            {
                if (Catalogs[i].CatalogId == CatalogId)
                {
                    Catalogs.RemoveAt(i);
                    break;
                }
            }
            ids.RemoveCatalog(CatalogId);
        }
        public void update()
        {
            delete();
            add();
        }

        public void load()
        {
            Catalogs.Clear();
            foreach (var catalog in ids.GetAllCatalog())
            {
                Catalogs.Add(new CatalogViewModel(CatalogId = catalog.catalogId, Title = catalog.title, Author = catalog.author, NrOfPages = catalog.nrOfPages));
            }
        }
    }
}
