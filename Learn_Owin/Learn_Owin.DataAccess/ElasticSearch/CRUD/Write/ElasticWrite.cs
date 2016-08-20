namespace Learn_Owin.DataAccess.ElasticSearch.CRUD.Write
{
    public class ElasticWrite
    {
        public bool IndexDocument<T>(T element) where T : class
        {
            var response = Connection.Client.Index(element, idx => idx.Index("movies"));
            return true;
        }
    }
}
