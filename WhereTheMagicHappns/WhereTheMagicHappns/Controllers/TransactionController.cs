using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhereTheMagicHappns.Models;

namespace WhereTheMagicHappns.Controllers
{
    public class TransactionController : ApiController
    {
        public HttpResponseMessage Post([FromBody]Transaction trans)
        {
            string msg = string.Format("Recebido");

           return Request.CreateResponse(HttpStatusCode.Created, msg);                       
        }
        public HttpResponseMessage Get([FromBody]int id)
        {
            string msg = string.Format("Entregue");

            return Request.CreateResponse(HttpStatusCode.Created, msg);
        }
    }
}
