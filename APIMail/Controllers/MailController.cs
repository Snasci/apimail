using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIMail.Contracts;
using APIMail.Models;

namespace APIMail.Controllers
{
    public class MailController : ApiController
    {
        [HttpPost]
        [Route("api/mail/submit")]
        public HttpResponseMessage Submit([FromBody] MailContract mailContract)
        {
            InMemoryDB imdb = InMemoryDB.Instance;
            imdb.AddMailToDB(mailContract);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
