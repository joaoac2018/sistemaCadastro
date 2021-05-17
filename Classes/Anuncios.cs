using System;

namespace sistemacadastro.Classes
{
    public class Anuncios : EntidadeBase
    {
        //ATRIBUTOS
        private string nomeAnuncio { get; set ;}
        private string nomeCliente { get; set; }
        private string dataInicio { get; set; }
        private string dataTermino { get; set; }
        private double investimentoPorDia { get; set; }
        private bool Excluido{ get; set; }

        //METODOS
        public Anuncios(int Id, string nomeAnuncio, string nomeCliente, string dataInicio, string dataTermino, 
        double investimentoPorDia)
        {
            this.Id = Id;
            this.nomeAnuncio = nomeAnuncio ;
            this.nomeCliente = nomeCliente;
            this.dataInicio = dataInicio;
            this.dataTermino = dataTermino;
            this.investimentoPorDia = investimentoPorDia;
            this.Excluido = false;
        }
        public string retornanuncio()
        {
            return this.nomeAnuncio;
        }
        public int retornaid()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

                        

                        
    }
}