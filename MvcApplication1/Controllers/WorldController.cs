using MvcApplication1.Models;
using MvcApplication1.Services;
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
        private WorldRepository worldRepository;

        public WorldController()
        {
            this.worldRepository = new WorldRepository();
        }

        public World[] Get()
        {
            return worldRepository.GetAllContacts();
        }

    }
}
