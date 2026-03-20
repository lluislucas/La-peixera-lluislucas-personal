public class Peix : Animal
{
    public Peix(ESexe sexe) : base(sexe)
    {
        
      
    }

    public override Animal Reproduccio()
    {

            return new Peix((ESexe.Aleatori));
    }
}
    

