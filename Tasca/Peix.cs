public class Peix : Animal
{
    //private static Random rPeix = new();
  
    public Peix(ESexe sexe) : base(sexe)
    {
        potAtacar = new(){"Peix"};
      
    }

    public override Animal Reproduccio()
    {

            return new Peix((ESexe.Aleatori));
    }
}
    

