using Industria.Domain.Entities.Enum;

namespace Industria.Domain.Entities
{
    public class Industria : BaseEntity
    {
        public Industria(int id, string codigo, string descricao, ETipo tipo)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Tipo = tipo;
        }

        public Industria ()
        {            
        }

        public string Codigo { get; set; }
        
        public string Descricao { get; set; }

        public ETipo Tipo { get; set; }
    }
}