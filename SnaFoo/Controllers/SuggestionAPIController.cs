using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SnaFoo.Controllers
{
    public class SuggestionAPIController : ApiController
    {
        // GET: api/SuggestionAPI
        public IEnumerable<Suggestion> Get()
        {
            using (var obj = new SnaFoo.natEntities())
            {
                return obj.Suggestions.ToList();
            }
        }

        // GET: api/SuggestionAPI/5
        public Suggestion Get(int id)
        {
            using (var obj = new SnaFoo.natEntities())
            {
                return obj.Suggestions.Where(s => s.Id == id).FirstOrDefault();
            }
        }

        //// POST: api/SuggestionAPI
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/SuggestionAPI/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/SuggestionAPI/5
        //public void Delete(int id)
        //{
        //}
    }
}
