using LibraryModel;

namespace LibraryViewModel
{
    public class CatalogViewModel : PropertyChange
    {
        public int catalogId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int nrOfPages { get; set; }
        public CatalogViewModel(int catalogId, string title, string author, int nrOfPages)
        {
            this.catalogId = catalogId;
            this.title = title;
            this.author = author;
            this.nrOfPages = nrOfPages;
        }
        public CatalogViewModel()
        {
            CatalogId = 0;
            Title = "";
            Author = "";
            NrOfPages = 0;
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
