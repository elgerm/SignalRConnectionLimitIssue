using Microsoft.AspNet.SignalR;
using SignalRConnectionLimitIssue.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace SignalRConnectionLimitIssue.Controllers
{
    [RoutePrefix("api/settings")]
    public class SettingsController : ApiController
    {
        [Route("canConnect")]
        [HttpGet]
        public IHttpActionResult CanConnect()
        {
            throw new NotImplementedException();
        }
    }
}
