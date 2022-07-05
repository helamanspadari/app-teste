using app_teste.Models.DTO.Marca;
using app_teste.Models.Entities.Marca;
using app_teste.Repositories.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace app_teste.Repositories.Repository.Marca
{
    public class MarcaRepository
    {
        #region ' Variaveis '
        private readonly IMapper _mapeador;
        private readonly AppDbContext _contexto;

        public MarcaRepository(AppDbContext context, IMapper mapper)
        {
            _contexto = context;
            _mapeador = mapper;
        }
        #endregion

        public List<MarcaDTO> ListarMarca()
        {
            try
            {
                List<MarcaEntities> lista = _contexto.Marca.ToList();

                List<MarcaDTO> listaDTO = _mapeador.Map<List<MarcaEntities>, List<MarcaDTO>>(lista);

                return listaDTO;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MarcaDTO ObterMarcar(int id)
        {
            try
            {
                MarcaEntities marca = _contexto.Marca
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == id);

                MarcaDTO marcaDTO = _mapeador.Map<MarcaEntities, MarcaDTO>(marca);

                return marcaDTO;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InserirMarca(MarcaDTO marcaDTO)
        {
            try
            {
                _contexto.Marca.Add(marcaDTO);
                _contexto.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarMarca(MarcaDTO marcaDTO)
        {
            try
            {
                _contexto.Entry(marcaDTO).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoverMarca(int id)
        {
            try
            {
                MarcaEntities marca = _contexto.Marca.Find(id);

                if(marca.Id > 0)
                {
                    _contexto.Marca.Remove(marca);
                    _contexto.SaveChanges();
                }
                else
                {
                    throw new Exception("Erro ao remover marca");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarExistencia(MarcaDTO marcaDTO)
        {
            try
            {
                int qtd = _contexto.Marca
                    .Where(x => x.Nome.ToLower().Trim().Equals(marcaDTO.Nome.ToLower().Trim()))
                    .Count();

                return Convert.ToBoolean(qtd);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public MarcaDTO AtualizarNomeMarca(MarcaDTO marcaDTO)
        {
            try
            {
                MarcaEntities marca = _contexto.Marca.Find(marcaDTO.Id);

                marcaDTO.Nome = marca.Nome;

                return marcaDTO;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
