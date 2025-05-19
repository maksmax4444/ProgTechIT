namespace LibraryLogicLayer
{
    internal class StateService : IStateService
    {
        public StateService(int i, int n, int c)
        {
            id = i;
            noBooks = n;
            catalogId = c;
        }
        public int id { get; set; }
        public int noBooks { get; set; }
        public int catalogId { get; set; }
    }
}
