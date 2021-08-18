using System.Collections.Generic;

namespace Series
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornoPorId(int id);

        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizacao(int id, T entidade);
        int ProximoId();
    }
}