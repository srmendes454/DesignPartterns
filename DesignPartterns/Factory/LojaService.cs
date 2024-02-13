using DesignPartterns.Builder;

namespace DesignPartterns.SimpleFactory
{
    public class LojaService
    {
        public static dynamic CriarLanche(string tipo)
        {
            var lanche = new object();
            switch (tipo)
            {
                case "H":

                    var cardapioHamburgues = new List<string> { "P - Podrão", "A - Artesanal", "T - Tradicional" };
                    Console.WriteLine("Bem vindo a nossa Hamburgueria - Selecione o tipo do Hamburguer desejado.\n" + string.Join("\n", cardapioHamburgues));

                    var hamburguerSelecionado = Console.ReadLine();
                    if (hamburguerSelecionado == "A")
                    {
                        var hamburgueria = new Hamburgueria(new HamburguerArtesanal());
                        hamburgueria.Montar();
                        var hamburguerArtesanal = hamburgueria.Obter();
                        hamburguerArtesanal.Conteudo();
                        lanche = hamburguerArtesanal;
                    }
                    break;

                case "P":
                    lanche = new Lanche { Nome = "Pizza Marguerita", Valor = 24.90m };
                    break;

                case "S":
                    lanche = new Lanche { Nome = "Coxinha", Valor = 7.90m };
                    break;

                case "PF":
                    lanche = new Lanche { Nome = "Arroz, Feijão, Carne, Salada", Valor = 18.90m };
                    break;
            }
            return lanche;
        }
    }
}
