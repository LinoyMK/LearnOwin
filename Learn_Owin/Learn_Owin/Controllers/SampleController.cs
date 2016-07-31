﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Learn_Owin.Controllers
{
    [RoutePrefix("api/sample")]
    public class SampleController : ApiController
    {
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("Linoy");
        }

        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            return Ok("Get with id");
        }
    }
}
