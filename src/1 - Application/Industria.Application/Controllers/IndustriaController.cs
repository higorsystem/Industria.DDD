namespace Industria.Application.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using Industria.Application.DTO;
    using Industria.Application.DTO.Parser;
    using Industria.Service.Service;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [Produces("application/json")]
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
            try
            {
                 var entidade = IndustriaParser.Parser(contrato);
                _service.Adicionar(entidade);
                return Ok(entidade);
            }
            catch(SqlException)
            {
                return BadRequest(new { message = "O campo 'Codigo' já está cadastrado na base, por favor altere para prosseguir com a operação."});
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = "Um error inesperado aconteceu. Por favor verifique se o seu contrato está correto!"});
            }
           
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<IndustriaDTO> Get(int id)
        {
            var entidade = _service.ObterPorId(id);
            if(entidade == null)
            {
                return NotFound(new { message = "O idenficador: " + id + " não foi encontrado na base de dados!"});
            }

            return Ok(IndustriaParser.Parser(entidade));
        }

        [HttpGet]        
        public ActionResult<List<IndustriaDTO>> GetAll()
        {
            var entidades = _service.ObterTodos();
            if(entidades.Any())
            {
                return Ok(IndustriaParser.Parser(entidades).ToList());
            }

            return NotFound(new { message = "Nenhum dado encontrado!"});
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

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var entidade = _service.ObterPorId(id);
                if(entidade != null)
                {
                    _service.Delete(id);
                    return Ok(new { message = "A industria: " + id + " foi excluída com sucesso."});
                }

                return NotFound(new { message = "O identificador: " + id + " não foi encontrado, portanto não pode ser excluído."});
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);
            }
        }
    }
}