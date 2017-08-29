using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GenAdxCDE.Source.Model.Domain;
using GenAdxCDE.Source.Model.Business;
using MySql.Data;

namespace GenAdx_REST.Controllers
{
    public class loginController : ApiController
    {
        // GET: api/login
        public IEnumerable<string> Get()
        {
            return new string[] { "Utilize numbered GET", "Request" };
        }

        // GET: api/login/5
        public login Get(int id)
        {
            login con = new login();
            loginManager ConMgr = new loginManager();
            con = ConMgr.Get(id);
            return con;
        }

        // POST: api/login
        public HttpResponseMessage Post([FromBody]login value)
        {
            login login = new GenAdxCDE.Source.Model.Domain.login()
            {
                userName = value.userName,
                passWord = value.passWord,
                
            };
            loginManager ConMgr = new loginManager();
            ConMgr.Create(login);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            loginManager ConIDMgr = new loginManager();
            
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("{0}", ConIDMgr.whatIsLoginID(value.userName)));
            return response;
        }

        // PUT: api/login/5
        public HttpResponseMessage Put(int id, [FromBody]login value)
        {
            login login = new GenAdxCDE.Source.Model.Domain.login()
            {
                userName = value.userName,
                passWord = value.passWord,
            };
            loginManager ConMgr = new loginManager();
            ConMgr.Update(login);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("consumer/{0}", value.userName));
            return response;

        }

        // DELETE: api/login/5
        public HttpResponseMessage Delete(string id)
        {
            login con = new login();
            con.userName = id;
            loginManager ConMgr = new loginManager();
            ConMgr.Delete(con);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;


        }
    }
}
