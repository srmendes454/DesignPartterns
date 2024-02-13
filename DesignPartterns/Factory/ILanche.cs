namespace DesignPartterns.SimpleFactory
{
    public interface ILanche
    {
        public abstract void PrepararPedido();
        public abstract void EmbalarPedido();
        public abstract void EnviarPedido();
    }
}
