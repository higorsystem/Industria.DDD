using System.ComponentModel;

namespace Industria.Domain.Entities.Enum
{
    public enum ETipo
    {
        [Description("Obtém ou define o tipo 'Cosmeticos'.")]
        Cosmeticos = 1,
        
        [Description("Obtém ou define o tipo 'Alimentos'.")]
        Alimentos = 2,
        
        [Description("Obtém ou define o tipo 'Maquinas'.")]
        Maquinas = 3
    }
}