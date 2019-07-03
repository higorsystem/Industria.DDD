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
        }

     //TODO terminar o crud aqui.
    }
}