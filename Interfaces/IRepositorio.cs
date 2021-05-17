using System.Collections.Generic;

namespace sistemacadastro.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualizar( int id, T entidade );
        int ProximoId();
         
    }
}