namespace Industria.Application.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
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
        public IndustriaDTO Get(int id)
        {
            var entidade = _service.ObterPorId(id);
            return IndustriaParser.Parser(entidade);
        }

        [HttpGet]
        [Route("listar-todos")]
        public List<IndustriaDTO> GetAll()
        {
            var entidades = _service.ObterTodos();
            return IndustriaParser.Parser(entidades).ToList();
        }

        [HttpPut]
        [Route("{id}")]
        public IndustriaDTO Put([FromBody] IndustriaDTO contrato, int id)
        {
            var entidade = _service.ObterPorId(id);
            if(entidade != null)
            {
                var contratoEditado = IndustriaParser.Parser(contrato, entidade);
                var entidadeEditada = _service.Alterar(contratoEditado);
                return IndustriaParser.Parser(entidadeEditada);    
            }

            return null;
        }
    }
}