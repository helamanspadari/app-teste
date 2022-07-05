using app_teste.Models.DTO.Marca;
using app_teste.Repositories.Repository.Marca;
using System.Collections.Generic;

namespace app_teste.Services.Service.Marca
{
    public class MarcaService
    {
        #region ' Variaveis '  
        private readonly MarcaRepository _repository;

        public MarcaService(MarcaRepository repository)
        {
            _repository = repository;
        }
        #endregion

        public List<MarcaDTO> ListarMarca()
        {
            return _repository.ListarMarca();
        }

        public MarcaDTO ObterMarca(int id)
        {
            return _repository.ObterMarcar(id);
        }

        public void InserirMarca(MarcaDTO marcaDTO)
        {
            marcaDTO.Status = true;

            if(!VerificarExistencia(marcaDTO))
                _repository.InserirMarca(marcaDTO);
        }

        public void AlterarStatusMarca(MarcaDTO marcaDTO)
        {
            marcaDTO = ObterMarca(marcaDTO.Id);

            if (marcaDTO.Status)
                marcaDTO.Status = false;
            else
                marcaDTO.Status = true;

            _repository.AlterarMarca(marcaDTO);
        }

        public void RemoverMarca(int id)
        {
            _repository.RemoverMarca(id);
        }

        public bool VerificarExistencia(MarcaDTO marcaDTO)
        {
            return _repository.VerificarExistencia(marcaDTO);
        }
    }
}
