namespace DesignPartterns.Builder
{
    public class Hamburgueria : IHamburgueria
    {
        private readonly HamburguerBuilder _builder;
        public Hamburgueria(HamburguerBuilder builder)
        {
            _builder = builder;
        }
        public void Montar()
        {
            _builder.Criar();
            _builder.ReceberPedido();
        }

        public Hamburguer Obter() => _builder.Obter();
    }
}
