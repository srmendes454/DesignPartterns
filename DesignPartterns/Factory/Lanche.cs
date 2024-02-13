
namespace DesignPartterns.SimpleFactory
{
    public class Lanche : ILanche
    {
        #region [ Propriedades ]
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        #endregion

        #region [ Metodos ]

        public void PrepararPedido() => Console.WriteLine($"Seu {Nome} já está sendo prepadado!");

        public void EmbalarPedido() => Console.WriteLine($"Seu {Nome} já está sendo embalado e pronto para ser enviado!");

        public void EnviarPedido() => Console.WriteLine($"Seu {Nome} já está a caminho de você!");

        #endregion
    }
}
