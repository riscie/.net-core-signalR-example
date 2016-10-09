using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Infrastructure;
using SignarRChat.Model;

namespace SignarRChat.Controllers
{
    [Route("api/[controller]")]
    public class BroadcastController : Controller
    {
        private readonly IHubContext _hub;


        public BroadcastController(IConnectionManager connectionManager)
        {
            _hub = connectionManager.GetHubContext<ChatHub>();
        }

        // GET api/broadcast/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            _hub.Clients.All.broadcastMessage("API", "GET: api/broadcast/" + id);
            return "value";
        }

        // POST api/broadcast
        [HttpPost]
        public void Post([FromBody] Message msg)
        {
            _hub.Clients.All.broadcastMessage("API", "POST: " + msg.Body);
        }

    }
}