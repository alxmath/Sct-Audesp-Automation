namespace Sct_Audesp_Automation.Entities
{
    /// <summary>
    /// Representa um item de empenho
    /// </summary>
    public class ItemEmpenho
    {
        #region Properties
        public int Sequencia { get; set; }
        public int Siafisico { get; set; }
        public string Unidade { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }

        #endregion  

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public ItemEmpenho()
        {
        }


        /// <summary>
        /// Construtor com 5 parâmetros
        /// </summary>
        /// <param name="sequencia">Sequência em que o item aparece no empenho</param>
        /// <param name="siafisico">Número do código siafisico do item</param>
        /// <param name="unidade">Unidade siafisico do item</param>
        /// <param name="quantidade">Quantidade do item</param>
        /// <param name="valorUnitario">Valor unitário do item</param>
        public ItemEmpenho(int sequencia, int siafisico, string unidade,
            double quantidade, double valorUnitario)
        {
            Sequencia = sequencia;
            Siafisico = siafisico;
            Unidade = unidade;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        /// <summary>
        /// Método que calcula o valor total do item
        /// </summary>
        /// <returns>Valor total do item</returns>
        public double GetValorTotal()
        {
            return Quantidade * ValorUnitario;
        }

        public override bool Equals(object obj)
        {
            return obj is ItemEmpenho empenho &&
                   Siafisico == empenho.Siafisico &&
                   ValorUnitario == empenho.ValorUnitario;
        }

        public override int GetHashCode()
        {
            int hashCode = -1322006337;
            hashCode = hashCode * -1521134295 + Siafisico.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorUnitario.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return string.Format($"Sequencia: {0}, Siafisico: {1}, Unidade: {2}," +
                $" Quantidade: {3}, Valor Unitário: {4}, Valor Total: {5}",
                Sequencia, Siafisico, Unidade, Quantidade, ValorUnitario, GetValorTotal());
        }
    }
}