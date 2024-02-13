using DesignPartterns.Builder;

namespace DesignPartterns.SimpleFactory
{
    public class Loja
    {
        public static void FazerPedido()
        {
            Console.WriteLine("======= Staff Code =======\n");

            var opcoes = new List<string> { "H - Hamburguer", "P - Pizza", "S - Salgados", "PF - Prato Freito" };
            Console.WriteLine("Qual o seu pedido ?\n" + string.Join("\n", opcoes));

            var lancheSelecionado = Console.ReadLine();
            try
            {
                Lanche lanche = LojaService.CriarLanche(lancheSelecionado);

                lanche.PrepararPedido();
                lanche.EmbalarPedido();
                lanche.EnviarPedido();

                Console.WriteLine("Lanche concluido!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro :" + ex.Message);
            }
        }
    }
}
