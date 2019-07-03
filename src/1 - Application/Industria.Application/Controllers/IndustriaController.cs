namespace Industria.Application.Controllers
{
    using System.Collections.Generic;
    using Industria.Application.DTO;
    using Industria.Application.DTO.Parser;
    using Industria.Service.Service;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class IndustriaController : ControllerBase
    {
        private IndustriaService _service;
        public IndustriaController()
        {            
            _service = new IndustriaService();
        }

        [HttpPost] 
        public IActionResult Post([FromBody] IndustriaDTO contrato)
        {
            var entidade = IndustriaParser.Parser(contrato);
            _service.Adicionar(entidade);
            return Ok(entidade);
        }

        [HttpGet]
        [Route("{id}")]
        public IndustriaDTO Get(string id)
        {
            return new IndustriaDTO();
        }

        [HttpGet]
        [Route("listar-todos")]
        public List<IndustriaDTO> GetAll()
        {
            return new List<IndustriaDTO>();
        }

        [HttpPut]
        [Route("{id}")]
        public IndustriaDTO Put([FromBody] IndustriaDTO contrato, string id)
        {
            return new IndustriaDTO();
        }
    }
}