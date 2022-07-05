using app_teste.Models.Entities.Marca;
using app_teste.Models.Entities.Proprietario;
using app_teste.Models.Enum.Veiculo;

namespace app_teste.Models.Entities.Veiculo
{
    public class VeiculoEntities : BaseEntity
    {
        public int Id { get; set; }
        public string Renavam { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public double Quilometragem { get; set; }
        public decimal Valor { get; set; }
        public EnumStatusVeiculo Status { get; set; }

        public int MarcaId { get; set; }
        public MarcaEntities Marca { get; set; }
        public int ProprietarioId { get; set; }
        public ProprietarioEntities Proprietario { get; set; }
    }
}
