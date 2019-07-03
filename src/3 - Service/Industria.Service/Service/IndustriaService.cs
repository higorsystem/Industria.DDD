using System.Collections.Generic;
using System.Linq;
using Industria.Data.Context;
using Industria.Data.Repository;

namespace Industria.Service.Service
{
    public class IndustriaService
    {
        private IndustriaRepository _repository;
        private IndustriaContext contexto;

        public IndustriaService()
        {
            contexto = new IndustriaContext();
            _repository = new IndustriaRepository(contexto);            
        }

        public void Adicionar(Industria.Domain.Entities.Industria contrato)
        {
            _repository.Adicionar(contrato);
            _repository.SaveChanges();
        }

        public Industria.Domain.Entities.Industria ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public List<Industria.Domain.Entities.Industria> ObterTodos()
        {
            return _repository.ObterTodos().ToList();
        }

        public Industria.Domain.Entities.Industria Alterar(Industria.Domain.Entities.Industria entidade)
        {
            if(entidade == null)
            {
                return null;
            }
            _repository.Atualizar(entidade);
            _repository.SaveChanges();
            return entidade;
        }

        public void Delete(int id)
        {
            var entidade = this.ObterPorId(id);
            
            if(entidade == null)
            {
                return;
            }

            _repository.Remover(id);
            _repository.SaveChanges();
        }     
    }
}