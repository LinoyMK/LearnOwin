using Learn_Owin.DataAccess.ElasticSearch.Model;
using Nest;

namespace Learn_Owin.DataAccess.ElasticSearch.CRUD.Read
{
    public class ElasticRead
    {

        public void Search(string text)
        {
            var data = GetData(text, "actor");
        }


        private ISearchResponse<dynamic> GetData(string searchText, string type)
        {
            var query = "1"; // This would be passed in
            if (string.IsNullOrWhiteSpace(type))
            {

            }

            var resp = Connection.Client.Search<dynamic>(s => s
               .Type(Types.Type(typeof(Movie)))
               .From(0)
               .Take(10)
               .Query(qry => qry
                   .Bool(b => b
                   .Must(m => m
                       .QueryString(qs => qs
                           .DefaultField("_all")
                           .Query(query)))))
                   //.Highlight(h => h.PreTags("<strong>").PostTags("</strong>").Fields(f => f.OnAll()))

                   );

            return resp;
        }
    }
}
