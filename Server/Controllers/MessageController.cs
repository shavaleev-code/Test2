using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace Server.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public string Get()
        {           
            using (var db = new MyAppContext())
            {
                var message = db.Messages;  
                if (message == null)
                {
                    return string.Empty;
                }

                return JsonConvert.SerializeObject(message);
            }
        }

        [HttpPost]
        public void Create([FromBody] Message message)
        {
            try
            {
                var db = new MyAppContext();
                if (message != null)
                {
                    db.Messages.Add(message);
                }

                db.SaveChanges();
            }
            catch (Exception e)
            {

            }
        }
    }
}
