namespace DesignPartterns.Builder
{
    public class Hamburgueria : IHamburgueria
    {
        private readonly HamburguerBuilder _builder;
        public Hamburgueria(HamburguerBuilder builder)
        {
            _builder = builder;
        }
        public void Montar(string nome)
        {
            _builder.Criar();
            _builder.ReceberPedido(nome);
        }

        public Hamburguer Obter() => _builder.Obter();
    }
}
