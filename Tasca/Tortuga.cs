public class Tortuga: Animal
{
    private static Random rPeix = new();
    public Tortuga(ESexe sexe) : base(sexe)
    {
      
      potAtacar = new(){"Tortuga"};
    }


}