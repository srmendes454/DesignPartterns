using DesignPartterns.Builder;
using DesignPartterns.Prototype;

namespace DesignPartterns.SimpleFactory
{
    public class LojaService
    {
        public static Lanche CriarLanche(string tipo, string nome)
        {
            var lanche = new Lanche 
            {
                Nome = "Teste",
                Valor = 0,
                Cliente = new Cliente { Nome = nome }
            };

            switch (tipo)
            {
                case "H":

                    var cardapioHamburgues = new List<string> { "P - Podrão", "A - Artesanal", "T - Tradicional" };
                    Console.WriteLine($"{nome}, Bem vindo a nossa Hamburgueria - Selecione o tipo do Hamburguer desejado.\n" + string.Join("\n", cardapioHamburgues));

                    var hamburguerSelecionado = Console.ReadLine();
                    if (hamburguerSelecionado == "A")
                    {
                        var hamburgueria = new Hamburgueria(new HamburguerArtesanal());
                        hamburgueria.Montar(nome);
                        var hamburguerArtesanal = hamburgueria.Obter();
                        hamburguerArtesanal.Conteudo();
                        lanche = hamburguerArtesanal;
                    }
                    break;

                case "P":
                    var pizza = (Lanche)lanche.Clone();
                    pizza.Nome = "Pizza Marguerita";
                    pizza.Valor = 24.90m;

                    lanche = pizza;
                    break;

                case "S":
                    var salgado = (Lanche)lanche.Clone();
                    salgado.Nome = "Coxinha com Catupiry";
                    salgado.Valor = 7.90m;

                    lanche = salgado;
                    break;

                case "PF":
                    var pratoFeito = (Lanche)lanche.Clone();
                    pratoFeito.Nome = "Arroz, Feijão, Salada, Carne";
                    pratoFeito.Valor = 18.90m;

                    lanche = pratoFeito;
                    break;
            }
            return lanche;
        }
    }
}
