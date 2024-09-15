using StylistPro.Compra.Domain.Entities;
using StylistPro.Compra.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StylistPro.Compra.Application.Services
{
    public class ComprasApplicationService : IComprasApplicationService
    {
        private readonly IComprasRepository _comprasRepository;

        public ComprasApplicationService(IComprasRepository comprasRepository)
        {
            _comprasRepository = comprasRepository;
        }

        public ComprasEntity? DeletarDadosCompras(int id)
        {
            return _comprasRepository.DeletarDados(id);
        }

        public ComprasEntity? EditarDadosCompras(ComprasEntity entity)
        {
            return _comprasRepository.EditarDados(entity);
        }

        public ComprasEntity? ObterComprasPorId(int id)
        {
            return _comprasRepository.ObterPorId(id);
        }

        public IEnumerable<ComprasEntity> ObterTodasCompras()
        {
            return _comprasRepository.ObterTodos();
        }

        public ComprasEntity? SalvarDadosCompras(ComprasEntity entity)
        {
            return _comprasRepository.SalvarDados(entity);

        }
    }
}
