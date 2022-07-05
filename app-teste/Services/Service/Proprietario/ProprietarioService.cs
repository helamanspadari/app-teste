using app_teste.Models.DTO.Proprietario;
using app_teste.Repositories.Repository.Proprietario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_teste.Services.Service.Proprietario
{
    public class ProprietarioService
    {
        #region ' Variaveis '
        private readonly ProprietarioRepository _repository;

        public ProprietarioService(ProprietarioRepository repository)
        {
            _repository = repository;
        }
        #endregion

        public List<ProprietarioDTO> ListarProprietario()
        {
            return _repository.ListarProprietario();
        }

        public ProprietarioDTO ObterProprietario(int id)
        {
            return _repository.ObterProprietario(id);
        }

        public void InserirProprietario(ProprietarioDTO proprietarioDTO)
        {
            if (!VerificarExistencia(proprietarioDTO))
                _repository.InserirProprietario(proprietarioDTO);
            else
                throw new Exception("Proprietario existente");
        }

        public void AlterarProprietario(ProprietarioDTO proprietarioDTO)
        {
            _repository.AlterarProprietario(proprietarioDTO);
        }

        public bool VerificarExistencia(ProprietarioDTO proprietarioDTO)
        {
            return _repository.VerificarExistencia(proprietarioDTO);
        }

    }
}
