using app_teste.Models.DTO.Veiculo;
using app_teste.Models.Entities.Veiculo;
using app_teste.Repositories.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace app_teste.Repositories.Repository.Veiculo
{
    public class VeiculoRepository
    {
        #region ' Variaveis '
        private readonly IMapper _mapeador;
        private readonly AppDbContext _contexto;

        public VeiculoRepository(AppDbContext context, IMapper mapper)
        {
            _contexto = context;
            _mapeador = mapper;
        }
        #endregion

        public List<VeiculoDTO> ListarVeiculo()
        {
            try
            {
                List<VeiculoEntities> lista = _contexto.Veiculo
                    .Include(v => v.Marca)
                    .Include(v => v.Proprietario)
                    .ToList();

                List<VeiculoDTO> listaDTO = _mapeador.Map<List<VeiculoEntities>, List<VeiculoDTO>>(lista);

                return listaDTO;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VeiculoDTO ObterVeiculo(int id)
        {
            try
            {
                VeiculoEntities veiculo = _contexto.Veiculo
                    .Include(v => v.Marca)
                    .Include(v => v.Proprietario)
                    .Where(v => v.Id == id)
                    .AsNoTracking()
                    .FirstOrDefault();

                VeiculoDTO veiculoDTO = _mapeador.Map<VeiculoEntities, VeiculoDTO>(veiculo);

                return veiculoDTO;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool InserirVeiculo(VeiculoDTO veiculoDTO)
        {
            try
            {
                _contexto.Veiculo.Add(veiculoDTO);
                var sucesso = _contexto.SaveChanges();

                return Convert.ToBoolean(sucesso);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AlterarVeiculo(VeiculoDTO veiculoDTO)
        {
            try
            {
                _contexto.Entry(veiculoDTO).State = EntityState.Modified;
                var sucesso = _contexto.SaveChanges();

                return Convert.ToBoolean(sucesso);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarExistencia(VeiculoDTO veiculoDTO)
        {
            try
            {
                int qtd = _contexto.Veiculo
                    .Where(x => x.Renavam.ToLower().Equals(veiculoDTO.Renavam.ToLower()))
                    .Count();

                return Convert.ToBoolean(qtd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
