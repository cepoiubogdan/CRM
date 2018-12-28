using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Test.Controllers
{
    public class LogInController : ApiController
    {
        // GET: api/LogIn
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LogIn/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LogIn
        public string Post([FromBody]string value)
        {
            var result = HttpContext.Current.Request.Form[value];
            string final_result = result.ToString();
            LogIn person = JsonConvert.DeserializeObject<LogIn>(final_result);
            if (person.user == "bogdan" && person.pass == "123")
            {
                //Result awnser = new Result();
                //awnser.result = "ok";
                //string json = JsonConvert.SerializeObject(awnser);
                return "ok";
            }
           
            else
            {
                //Result awnser = new Result();
                //awnser.result = "Incorrect";
                //string json = JsonConvert.SerializeObject(awnser);
                return "notok";
            }

        }

        // PUT: api/LogIn/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LogIn/5
        public void Delete(int id)
        {
        }
    }
    class LogIn
    {
        public string command;
        public string user;
        public string pass;
    }
    class Result
    {
        public string result;
        //public Result(string result)
        //{
        //    this.result = result;
        //}
    }
}
