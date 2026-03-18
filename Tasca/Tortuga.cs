public class Tortuga: Animal
{
    private static Random rPeix = new();
    public Tortuga(ESexe sexe) : base(sexe)
    {
      
      potAtacar = new(){"Tortuga"};
    }

    public override Animal Reproduccio()
    {

            return new Tortuga((ESexe.Aleatori));
    }


}