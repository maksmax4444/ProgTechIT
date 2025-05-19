namespace LibraryDataLayer
{
    public abstract class IUser
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
