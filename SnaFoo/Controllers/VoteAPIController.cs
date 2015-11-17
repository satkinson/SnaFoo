using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SnaFoo.Controllers
{
    public class VoteAPIController : ApiController
    {
        // GET: api/VoteAPI
        public IEnumerable<Vote> Get()
        {
            using (var db = new SnaFoo.natEntities())
            {
                return db.Votes.ToList();
            }
        }

        // GET: api/VoteAPI/5
        public Vote Get(int id)
        {
            using (var db = new SnaFoo.natEntities())
            {
                return db.Votes.Where(v => v.Id == id).FirstOrDefault();
            }
        }

        // POST: api/VoteAPI
        public void Post([FromBody]string value)
        {
            using (var db = new SnaFoo.natEntities())
            {
                var vote = new Vote();
                vote.SnackId = Int32.Parse(value);
                vote.VotedOn = DateTime.Now;

                db.Votes.Add(vote);
                db.SaveChanges();
            }
        }

        //// PUT: api/VoteAPI/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/VoteAPI/5
        //public void Delete(int id)
        //{
        //}
    }
}
