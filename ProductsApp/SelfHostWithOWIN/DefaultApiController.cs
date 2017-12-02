using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace SelfHostWithOWIN
{
    public class DefaultApiController : ApiController
    {
        // api/Get
        public IEnumerable<string> Get()
        {
            return new string[] {"DotNet", "MVC", "C#"};
        }

        // api/Get/id
        public string Get(int id)
        {
            return "the value is " + id.ToString();
        }


    }
}
