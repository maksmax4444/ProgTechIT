using System.Windows.Input;
using LibraryLogicLayer;
using PresentationLayer.Model;

namespace PresentationLayer.ViewModel
{
    internal class CatalogViewModel : PropertyChange
    {
        private int catalogId;
        private string title;
        private string author;
        private int nrOfPages;
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Maksym\\Documents\\ProgTechRepo\\ProgTechIT\\LibraryDataLayer\\LibraryDatabase.mdf;Integrated Security = True";
        private IDataService ids = IDataService.CreateNewDataService(connectionString);
        private ICatalogModel icm;
        public ICommand AddSmth { get; }
        public ICommand DeleteSmth { get; }
        public ICommand UpdateSmth { get; }

        public CatalogViewModel(int catalogId, string title, string author, int nrOfPages)
        {
            this.catalogId = catalogId;
            this.title = title;
            this.author = author;
            this.nrOfPages = nrOfPages;

            AddSmth = new RelayCommand(_ => add());
            DeleteSmth = new RelayCommand(_ => delete());
            UpdateSmth = new RelayCommand(_ => update());
        }

        public CatalogViewModel()
        {
            CatalogId = 0;
            Title = "";
            Author = "";
            NrOfPages = 0;

            AddSmth = new RelayCommand(_ => add());
            DeleteSmth = new RelayCommand(_ => delete());
            UpdateSmth = new RelayCommand(_ => update());
        }
        public int CatalogId
        {
            get
            {
                return this.catalogId;
            }

            set
            {
                this.catalogId = value;
                OnPropertyChanged(nameof(CatalogId));
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                this.author = value;
                OnPropertyChanged(nameof(Author));
            }
        }

        public int NrOfPages
        {
            get
            {
                return this.nrOfPages;
            }

            set
            {
                this.nrOfPages = value;
                OnPropertyChanged(nameof(NrOfPages));
            }
        }

        public void add()
        {
            ids.AddCatalog(catalogId, title, author, nrOfPages);
        }

        public void delete()
        {
            ids.RemoveCatalog(catalogId);
        }

        public void update()
        {
            ids.UpdateCatalog(catalogId, title, author, nrOfPages);
        }
    }
}
