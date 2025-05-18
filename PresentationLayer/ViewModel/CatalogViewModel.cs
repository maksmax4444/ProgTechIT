namespace PresentationLayer.ViewModel
{
    internal class CatalogViewModel : PropertyChange
    {
        private int catalogId;
        private string title;
        private string author;
        private int nrOfPages;

        public CatalogViewModel(int catalogId, string title, string author, int nrOfPages)
        {
            this.catalogId = catalogId;
            this.title = title;
            this.author = author;
            this.nrOfPages = nrOfPages;
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
    }
}
