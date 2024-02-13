
using DesignPartterns.Prototype;

namespace DesignPartterns.SimpleFactory
{
    public class Lanche : ICloneable
    {
        #region [ Propriedades ]
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Cliente Cliente { get; set; }
        #endregion

        #region [ Construtores ]
        public Lanche() { }

        #endregion

        #region [ Metodos ]

        public void PrepararPedido() => Console.WriteLine($"{Cliente.Nome}, seu {Nome} já está sendo prepadado!");

        public void EmbalarPedido() => Console.WriteLine($"{Cliente.Nome}, seu {Nome} já está sendo embalado e pronto para ser enviado!");

        public void EnviarPedido() => Console.WriteLine($"{Cliente.Nome}, seu {Nome} já está a caminho de você!");

        public object Clone()
        {
            var lanche = (Lanche)MemberwiseClone();
            lanche.Cliente = (Cliente)Cliente.Clone();

            return lanche;
        }

        #endregion
    }
}
