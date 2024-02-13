namespace DesignPartterns.Builder
{
    public interface IHamburgueria
    {
        void Montar(string nome);
        Hamburguer Obter();
    }
}
