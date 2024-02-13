using DesignPartterns.Prototype;
using DesignPartterns.SimpleFactory;

namespace DesignPartterns.Builder
{
    public class Hamburguer : Lanche
    {
        public string Pao { get; set; }
        public string Carne { get; set; }
        public string Molho { get; set; }
        public List<string> Salada { get; set; }

        public void Conteudo()
        {
            Console.WriteLine($"Você selecionou {Nome}");
            Console.WriteLine($"Acompanha o Pão {Pao}");
            Console.WriteLine($"Carne {Carne}");
            Console.WriteLine($"Molho {Molho}");
            Console.WriteLine($"Salada {string.Join(", ", Salada)}");
            Console.WriteLine($"Valor total de: R$ {Valor}");
        }
    }

    public class HamburguerArtesanal : HamburguerBuilder
    {
        public override void ReceberPedido(string nome)
        {
            hamburguer.Cliente = new Cliente { Nome = nome };
            hamburguer.Nome = "Hamburguer Artesanal";
            hamburguer.Pao = "Australiano";
            hamburguer.Carne = "180g - Picanha";
            hamburguer.Molho = "Barbecue";
            hamburguer.Salada = ["Picles", "Alface", "Azeitona Verde"];
            hamburguer.Valor = 39.90m;
        }

        public override void PedidoRecebido() => Console.WriteLine("Pedido recebido com sucesso!");
    }
}
