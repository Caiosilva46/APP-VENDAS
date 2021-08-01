using System;
using System.Collections.Generic;
using vendas.Interfaces;

namespace vendas.Classes
{
    public class HqRepositorio : BaseInterface<Hqs>
    {
        private List<Hqs> listaHqs = new List<Hqs>();
        public void Atualiza(int id, Hqs entidade)
        {
            listaHqs[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaHqs[id].Excluir();
        }

        public void Inserir(Hqs entidade)
        {
            listaHqs.Add(entidade);
        }

        public List<Hqs> Lista()
        {
            return listaHqs;
        }

        public int ProximoId()
        {
            return listaHqs.Count;
        }

        public Hqs RetornaId(int id)
        {
            return listaHqs[id];
        }
    }
}