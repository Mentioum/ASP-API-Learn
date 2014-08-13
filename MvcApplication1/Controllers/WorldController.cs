using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class WorldController : ApiController
    {

        public World[] Get()
        {
            return new World[]
            {
                new World
                {
                    Id = 1,
                    Name = "The First World"
                },
                new World
                {
                    Id = 2,
                    Name = "The Second World"
                }
            };
        }

    }
}
