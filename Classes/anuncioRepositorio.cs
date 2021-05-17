using System;
using System.Collections.Generic;
using sistemacadastro.Interfaces;

namespace sistemacadastro.Classes
{
    public class anuncioRepositorio : IRepositorio<Anuncios>
    {
        private List<Anuncios> listaAnuncios = new List<Anuncios>();
        public void Atualizar(int id, Anuncios objeto)
        {
            listaAnuncios[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaAnuncios[id].Excluir(); 
        }

        public void Insere(Anuncios objeto)
        {
            listaAnuncios.Add(objeto);
        }

        public List<Anuncios> lista()
        {
            return listaAnuncios;
        }

        public int ProximoId()
        {
            return listaAnuncios.Count;
        }

        public Anuncios RetornaPorId(int id)
        {
            return listaAnuncios[id];
        }
    }
}