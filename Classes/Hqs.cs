using System;


namespace vendas
{
    public class Hqs : EntidadeBase
    {
        public Hqs(Classificacao classificacao, string titulo, string descricao, int lancamento)
        {
            this.Classificacao = classificacao;
            this.Titulo = Titulo;
            this.Descricao = descricao;
            this.Lancamento = lancamento;
        }
        public Hqs(Classificacao classificacao, string descricao, int lancamento)
        {
            this.Classificacao = classificacao;
            this.Descricao = descricao;
            this.Lancamento = lancamento;
        }
        private Classificacao Classificacao { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Lancamento { get; set; }

        private bool Excluido { get; set; }


        public Hqs(int Id, Classificacao classificacao, string Titulo, string Descricao, int Lancamento)
        {
            this.Id = Id;
            this.Classificacao = classificacao;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Lancamento = Lancamento;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Classificação: " + this.Classificacao + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Lançamento: " + this.Lancamento + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        internal int retornoId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }

}
