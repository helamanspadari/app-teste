using app_teste.Models.DTO.Proprietario;
using app_teste.Models.Entities.Proprietario;
using app_teste.Repositories.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace app_teste.Repositories.Repository.Proprietario
{
    public class ProprietarioRepository
    {
        #region ' Variaveis '
        private readonly IMapper _mapeador;
        private readonly AppDbContext _contexto;

        public ProprietarioRepository(AppDbContext context, IMapper mapper)
        {
            _contexto = context;
            _mapeador = mapper;
        }
        #endregion

        public List<ProprietarioDTO> ListarProprietario()
        {
            try
            {
                List<ProprietarioEntities> lista = _contexto.Proprietario.ToList();

                List<ProprietarioDTO> listaDTO = _mapeador.Map<List<ProprietarioEntities>, List<ProprietarioDTO>>(lista);

                return listaDTO;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ProprietarioDTO ObterProprietario(int id)
        {
            try
            {
                ProprietarioEntities proprietario = _contexto.Proprietario
                    .Where(x => x.Id == id)
                    .AsNoTracking()
                    .FirstOrDefault();

                ProprietarioDTO proprietarioDTO = _mapeador.Map<ProprietarioEntities, ProprietarioDTO>(proprietario);

                return proprietarioDTO;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void InserirProprietario(ProprietarioDTO proprietarioDTO)
        {
            try
            {
                _contexto.Proprietario.Add(proprietarioDTO);
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarProprietario(ProprietarioDTO proprietarioDTO)
        {
            try
            {
                _contexto.Entry(proprietarioDTO).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarExistencia(ProprietarioDTO proprietarioDTO)
        {
            try
            {
                int qtd = _contexto.Proprietario
                    .Where(x => x.Documento.Trim() == proprietarioDTO.Documento.Trim())
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
