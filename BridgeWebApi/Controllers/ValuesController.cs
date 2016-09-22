using System;
using System.Collections.Generic;
using System.Web.Http;

namespace BridgeWebApi.Controllers
{    
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
	        return new string[] {"value1", "value2"};
        }

        // GET api/values/5
        public UserData Get(int id)
        {
            return new UserData()
            {
	            id = id,
				name = "Costel",
				age = 18
            };
        }

        // POST api/values
        public void Post([FromBody] UserData user)
        {
	        Console.WriteLine("Name: {0}, Age: {1}",
								user.name, user.age);
			// save data
	        
        }



        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

	public class UserData
	{
		public int id { set; get; }
		public string name { set; get; }
		public int age { set; get; }
	}
}
