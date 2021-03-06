using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppCalculator2.Controllers
{
    [RoutePrefix("api/Calculator")]
    public class CalculatorController : ApiController
    {
        [HttpGet]
        [Route("add")]
        public int Add(int i, int j)
        {
            return i + j;
        }

        [HttpGet]
        [Route("sub")]
        public int Sub(int i, int j)
        {
            return i - j;
        }

        [HttpGet]
        [Route("multiply")]
        public int Mult(int i, int j)
        {
            return i * j;
        }

        [HttpGet]
        [Route("divide")]
        public int Div(int i, int j)
        {
            return i / j;
        }

        [HttpGet]
        [Route("remainder")]
        public int Rem(int i, int j)
        {
            return i % j;
        }
    }
}
