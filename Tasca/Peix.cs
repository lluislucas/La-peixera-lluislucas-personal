public class Peix : Animal
{
    private static Random rPeix = new();
  
    public Peix(ESexe sexe) : base(sexe)
    {
        potAtacar = new(){"Peix"};
      
    }
    
    //public abstract Animal? Reproduccio(Animal altre, (int x, int y) MidaPeixera);

    public override Animal Reproduccio()
    {

            return new Peix();
    }
}
    

