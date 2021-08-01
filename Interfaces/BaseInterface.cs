using System;
using System.Collections.Generic;

namespace vendas.Interfaces
{
    public interface BaseInterface<T>
    {
        List<T> Lista();

        T RetornaId(int id);

        void Inserir(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId();

    }
}