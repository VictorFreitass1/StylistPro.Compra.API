using StylistPro.Compra.API.Entities;

namespace StylistPro.Compra.API.Repositories
{
    public interface IComprasRepository
    {
        IEnumerable<ComprasEntity> ObterTodos();
        ComprasEntity? ObterPorId(int id);
        ComprasEntity? SalvarDados(ComprasEntity entity);
        ComprasEntity? EditarDados(ComprasEntity entity);
        ComprasEntity? DeletarDados(int id);

    }
}