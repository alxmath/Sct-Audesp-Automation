using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sct_Audesp_Automation.Entities
{
    /// <summary>
    /// Classe que representa um empenho
    /// </summary>
    class Empenho
    {
        #region Properties

        public string Numero { get; set; }
        public string CnpjFornecedor { get; set; }
        public string RazaoFornecedor { get; set; }
        public string Processo { get; set; }
        public string Fonte { get; set; }
        public string Natureza { get; set; }
        public string TipoLicitacao { get; set; }
        public string Modalidade { get; set; }
        public int TipoContratacao { get; set; }
        public double Valor { get; set; }
        public DateTime DataEntrega { get; set; }
        public double ValorExecucoes { get; set; }
        public double ValorNFS { get; set; }
        public double ValorPagamentos { get; set; }
        public bool IsEncerrado { get; set; }

        public List<ItemEmpenho> Itens { get; } = new List<ItemEmpenho>();

        #endregion

        /// <summary>
        /// Contrutor padrão
        /// </summary>
        public Empenho() 
        {
        }

        /// <summary>
        /// Construtor com 15 parâmetros
        /// </summary>
        /// <param name="numero">Número do empenho</param>
        /// <param name="cnpjFornecedor">Cnpj do fornecedor</param>
        /// <param name="razaoFornecedor">Razão social do fornecedor</param>
        /// <param name="processo">Número do processo administrativo</param>
        /// <param name="fonte">Fonte de recursos</param>
        /// <param name="natureza">Natureza de despesa</param>
        /// <param name="tipoLicitacao">Tipo da Licitação (pregão eletrônico, dispensa de licitação etc.)</param>
        /// <param name="modalidade">Modalidade da licitação</param>
        /// <param name="tipoContratacao">Tipo do objeto da contratação (serviço ou material)</param>
        /// <param name="valor">Valor total da licitação</param>
        /// <param name="dataEntrega">Data estimada da entrega do serviço ou material</param>
        /// <param name="valorExecucoes">Valor das execuções transmitidas até o momento</param>
        /// <param name="valorNFS">Valor dos documentos fiscais transmitidos até o momento</param>
        /// <param name="valorPagamentos">Valor dos pagamentos transmitidos até o momento</param>
        /// <param name="isEncerrado">Determina se este empenho encerrou seu ciclo de vida no Audesp</param>
        public Empenho(string numero, string cnpjFornecedor, string razaoFornecedor,
            string processo, string fonte, string natureza, string tipoLicitacao,
            string modalidade, int tipoContratacao, double valor,
            DateTime dataEntrega, double valorExecucoes, double valorNFS,
            double valorPagamentos, bool isEncerrado)
        {
            Numero = numero;
            CnpjFornecedor = cnpjFornecedor;
            RazaoFornecedor = razaoFornecedor;
            Processo = processo;
            Fonte = fonte;
            Natureza = natureza;
            TipoLicitacao = tipoLicitacao;
            Modalidade = modalidade;
            TipoContratacao = tipoContratacao;
            Valor = valor;
            DataEntrega = dataEntrega;
            ValorExecucoes = valorExecucoes;
            ValorNFS = valorNFS;
            ValorPagamentos = valorPagamentos;
            IsEncerrado = isEncerrado;
        }

        public override bool Equals(object obj)
        {
            return obj is Empenho empenho &&
                   Numero == empenho.Numero;
        }

        public override int GetHashCode()
        {
            return -1449941195 + EqualityComparer<string>.Default.GetHashCode(Numero);
        }

        public override string ToString()
        {
            return string.Format($"Número: {0}, Cnpj: {1}, Razão: {2}, Processo: {3}, Fonte: {4}, " +
                $"Natureza {5}, Tipo: {6}, Modalidade: {7}, Contratação: {8}, Valor: {9}, " +
                $"Entrega: {10}, Execuções: {11}, NFS: {12}, Pagamentos: {13}, IsEncerrado: {14}",
                Numero, CnpjFornecedor, RazaoFornecedor, Processo, Fonte, Natureza, TipoLicitacao,
                Modalidade, TipoContratacao, Valor, DataEntrega, ValorExecucoes, ValorNFS, ValorPagamentos,
                IsEncerrado);
        }
    }
}
