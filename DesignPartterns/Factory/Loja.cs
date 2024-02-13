namespace DesignPartterns.SimpleFactory
{
    public class Loja
    {
        public static void FazerPedido()
        {
            Console.WriteLine("======= Staff Code =======\n");

            Console.WriteLine("Qual seu nome ?");
            var nome = Console.ReadLine();

            var opcoes = new List<string> { "H - Hamburguer", "P - Pizza", "S - Salgados", "PF - Prato Freito" };
            Console.WriteLine($"Qual o seu pedido {nome} ?\n" + string.Join("\n", opcoes));

            var lancheSelecionado = Console.ReadLine();
            try
            {
                Lanche lanche = LojaService.CriarLanche(lancheSelecionado, nome);

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
