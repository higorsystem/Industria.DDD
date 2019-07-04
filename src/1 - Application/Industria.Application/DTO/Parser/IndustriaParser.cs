using System.Collections.Generic;
using System.Linq;
using Industria.Domain.Entities.Enum;

namespace Industria.Application.DTO.Parser
{
    public class IndustriaParser
    {
        public static IndustriaDTO Parser(Industria.Domain.Entities.Industria entidade)
        {
            if(entidade == null) return null;

            var contrato = new IndustriaDTO();
            contrato.Id = entidade.Id;
            contrato.Codigo = entidade.Codigo;
            contrato.Descricao = entidade.Descricao;
            contrato.Tipo = (int) entidade.Tipo;

            return contrato;
        }

        public static Industria.Domain.Entities.Industria Parser(IndustriaDTO contrato, Industria.Domain.Entities.Industria entidade)
        {
            if(entidade == null) return null;
            
            entidade.Codigo = contrato.Codigo ?? entidade.Codigo;
            entidade.Descricao = contrato.Descricao ?? entidade.Descricao;
            entidade.Tipo = (ETipo) (contrato.Tipo != 0 ? contrato.Tipo : (int) entidade.Tipo);

            return entidade;
        }

        public static IEnumerable<IndustriaDTO> Parser(List<Industria.Domain.Entities.Industria> listaEntidades)
        {
            return listaEntidades.Select(Parser).ToList();
        }

        public static Industria.Domain.Entities.Industria Parser(IndustriaDTO contrato)
        {
            if (contrato == null)
            {
                return null;
            }

            var entidade = new Industria.Domain.Entities.Industria();
            entidade.Codigo = contrato.Codigo;
            entidade.Descricao = contrato.Descricao;
            entidade.Tipo = (Domain.Entities.Enum.ETipo) contrato.Tipo;

            return entidade;
        }
    }
}