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
                    lanche = new Lanche("Hamburguer Artesanal", 19.90m);
                    break;

                case "P":
                    lanche = new Lanche("Pizza Marguerita", 39.90m);
                    break;

                case "S":
                    lanche = new Lanche("Kibe", 6.90m);
                    break;

                case "PF":
                    lanche = new Lanche("Arroz, feijão e batata frita", 18.90m);
                    break;
            }
            return lanche;
        }
    }
}
