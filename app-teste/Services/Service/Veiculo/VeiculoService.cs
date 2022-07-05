using app_teste.Models.DTO.Marca;
using app_teste.Models.DTO.Proprietario;
using app_teste.Models.DTO.Veiculo;
using app_teste.Models.Enum.Veiculo;
using app_teste.Repositories.Repository.Veiculo;
using app_teste.Services.RabbitMQ;
using app_teste.Services.Service.Marca;
using app_teste.Services.Service.Proprietario;
using System;
using System.Collections.Generic;
using System.Linq;

namespace app_teste.Services.Service.Veiculo
{
    public class VeiculoService
    {
        #region ' Variaveis '  
        private readonly VeiculoRepository _repository;
        private readonly MarcaService _marcaService;
        private readonly ProprietarioService _proprietarioService;
        private readonly RabbitMqService _rabbitService;

        public VeiculoService(VeiculoRepository repository
            , MarcaService marcaService
            , ProprietarioService proprietarioService
            , RabbitMqService rabbitMqService)
        {
            _repository = repository;
            _marcaService = marcaService;
            _proprietarioService = proprietarioService;
            _rabbitService = rabbitMqService;
        }
        #endregion

        public List<VeiculoDTO> ListarVeiculo()
        {
            return _repository.ListarVeiculo();
        }

        public VeiculoDTO ObterVeiculo(int id)
        {
            return _repository.ObterVeiculo(id);
        }

        public bool InserirVeiculo(VeiculoDTO veiculoDTO)
        {
            bool sucesso = false;

            if(!VerificarExistencia(veiculoDTO))
                sucesso = _repository.InserirVeiculo(veiculoDTO);

            if(sucesso)
            {
                veiculoDTO.Proprietario = _proprietarioService.ObterProprietario(veiculoDTO.ProprietarioId);
                
                NotificarProprietarioCadastro(veiculoDTO);
            }

            return sucesso;
        }

        public bool AlterarVeiculo(VeiculoDTO veiculoDTO)
        {
            bool sucesso = false;

            ValidarVeiculo(veiculoDTO);

            sucesso = _repository.AlterarVeiculo(veiculoDTO);

            return sucesso;
        }



        public void NotificarProprietarioCadastro(VeiculoDTO veiculoDTO) 
        {
            _rabbitService.EnviarMensagem(new RabbitMqConfiguration.RabbitMqMensagem
            {
                DthMensagem = DateTime.Now,
                Origem = "ptcveiculos@email.com",
                Destino = veiculoDTO.Proprietario.Email,
                Conteudo = $"Veiculo: {veiculoDTO.Modelo}, cadastrado com sucesso em { DateTime.Now }"
            });
        }

        public bool VerificarExistencia(VeiculoDTO veiculoDTO)
        {
            return _repository.VerificarExistencia(veiculoDTO);
        }

        public void ValidarVeiculo(VeiculoDTO veiculoDTO)
        {
            VeiculoDTO veiculoDB = _repository.ObterVeiculo(veiculoDTO.Id);

            ValidarRenavam(veiculoDTO, veiculoDB);

            ValidarStatus(veiculoDTO, veiculoDB);
        }

        public void ValidarRenavam(VeiculoDTO veiculoDTO, VeiculoDTO veiculoDB)
        {
            if(veiculoDB.Renavam != veiculoDTO.Renavam)
            {
                bool existe = VerificarExistencia(veiculoDTO);

                if(existe)
                    throw new Exception("Renavam existente");
            }
        }

        public void ValidarStatus(VeiculoDTO veiculoDTO, VeiculoDTO veiculoDB)
        {
            if (veiculoDB.Status != EnumStatusVeiculo.Disponivel && veiculoDTO.Status == EnumStatusVeiculo.Disponivel)
                throw new Exception("Status não pode voltar para Disponivel, tente novamente!");
        }



        public List<MarcaDTO> ListarMarca()
        {
            return _marcaService.ListarMarca()
                .Where(x => x.Status)
                .ToList();
        }

        public List<ProprietarioDTO> ListarProprietario()
        {
            return _proprietarioService.ListarProprietario()
                .Where(x => x.Status)
                .ToList();
        }

        public List<VeiculoStatusDTO> ListarStatus()
        {
            List<VeiculoStatusDTO> listaStatus = new List<VeiculoStatusDTO>();
            
            listaStatus.Add(new VeiculoStatusDTO() { Id = (int)EnumStatusVeiculo.Disponivel, DscStatus = "Disponivel" });
            listaStatus.Add(new VeiculoStatusDTO() { Id = (int)EnumStatusVeiculo.Indisponivel, DscStatus = "Indisponivel" });
            listaStatus.Add(new VeiculoStatusDTO() { Id = (int)EnumStatusVeiculo.Vendido, DscStatus = "Vendido" });
            
            return listaStatus;
        }
    }
}
