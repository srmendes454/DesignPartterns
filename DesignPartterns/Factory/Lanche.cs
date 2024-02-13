
namespace DesignPartterns.SimpleFactory
{
    public class Lanche : ILanche
    {
        #region [ Construtor ]
        public Lanche(string nome, decimal valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
        }
        #endregion

        #region [ Propriedades ]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        #endregion

        #region [ Metodos ]

        public void ComputarPedido() => Console.WriteLine($"Pedido de {Nome} no valor de R$ {Valor} recebido com sucesso!");

        public void PrepararPedido() => Console.WriteLine($"Seu {Nome} já está sendo prepadado!");

        public void EmbalarPedido() => Console.WriteLine($"Seu {Nome} já está sendo embalado e pronto para ser enviado!");

        public void EnviarPedido() => Console.WriteLine($"Seu {Nome} já está a caminho de você!");

        #endregion
    }
}
