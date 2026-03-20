public class Tortuga: Animal
{
   
    public Tortuga(ESexe sexe) : base(sexe)
    {
      
    }

    public override Animal Reproduccio()
    {

            return new Tortuga((ESexe.Aleatori));
    }


}