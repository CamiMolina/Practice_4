using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Logic;
using Data;

namespace Practica_4.Controllers
{
    [ApiController]
    [Route("/api/groups")]
    public class GroupsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly InterGroupMan _groupMan;
        public GroupsController(IConfiguration config,InterGroupMan groupMan)
        {
            _config = config;
            _groupMan = groupMan;
        }
        [HttpGet]
        public List<Group> GetGroups()
        {
           
            return _groupMan.GetAllGroups();
            
        }
        [HttpPost]
        public Group CrearGrupo([FromBody] Group group)
        {
            return _groupMan.CrearGrupo(group);
           
        }
        [HttpPut]
        public Group ActualizarGrupo([FromBody] Group group)
        {
            return _groupMan.ActualizarGrupo(group);

        }
        [HttpDelete]
        public Group BorrarGrupo([FromBody] Group group)
        {
            return _groupMan.BorrarGrupo(group);

        }
    }
}
