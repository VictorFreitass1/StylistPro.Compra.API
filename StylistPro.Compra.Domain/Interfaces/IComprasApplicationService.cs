using StylistPro.Compra.Domain.Entities;

namespace StylistPro.Compra.Domain.Interfaces
{
    public interface IComprasApplicationService
    {
        IEnumerable<ComprasEntity> ObterTodasCompras();
        ComprasEntity? ObterComprasPorId(int id);
        ComprasEntity? SalvarDadosCompras(ComprasEntity entity);
        ComprasEntity? EditarDadosCompras(ComprasEntity entity);
        ComprasEntity? DeletarDadosCompras(int id);

    }
}