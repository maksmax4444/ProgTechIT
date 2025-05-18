using System.Windows.Input;

namespace PresentationLayer.ViewModel
{
    internal class CatalogViewModelCollection : PropertyChange
    {
        private int catalogId;
        private string title;
        private string author;
        private int nrOfPages;
        public ICommand commandAdd { get; }
        public ICommand commandDelete { get; }
        private List<CatalogViewModel> catalogs;

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
        public CatalogViewModelCollection()
        {
            catalogs = new List<CatalogViewModel>();
            //Place for commands
        }
        private async Task Add()
        {
            //Placeholder for commandAdd
        }
        private async Task Delete()
        {
            //Placeholder for commandDelete
        }
    }
}
