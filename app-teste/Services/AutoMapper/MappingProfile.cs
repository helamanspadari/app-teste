using app_teste.Models.DTO.Marca;
using app_teste.Models.DTO.Proprietario;
using app_teste.Models.DTO.Veiculo;
using app_teste.Models.Entities.Marca;
using app_teste.Models.Entities.Proprietario;
using app_teste.Models.Entities.Veiculo;
using AutoMapper;

namespace app_teste.Services.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProprietarioEntities, ProprietarioDTO>();
            CreateMap<MarcaEntities, MarcaDTO>();
            CreateMap<VeiculoEntities, VeiculoDTO>();
        }
    }
}
