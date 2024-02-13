namespace DesignPartterns.Prototype
{
    public class Cliente
    {
        public string Nome { get; set; }

        public object Clone() => (Cliente)MemberwiseClone();
    }
}
