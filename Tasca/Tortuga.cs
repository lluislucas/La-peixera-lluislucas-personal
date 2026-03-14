public class Tortuga: Animal
{
    private static Random rPeix = new();
    public Tortuga(ESexe sexe) : base(sexe)
    {
      
      
    }

    
   /* public override Animal? Interactuar(Animal altre)
    {

        if(altre is Tortuga tortu)
        {
            if(Sexe == tortu.Sexe)
            {
                Morir();
                tortu.Morir();
            }
            else
            {
                return Reproduccio();
                
            }
        
        }
        return null;
    }

    public override Animal Reproduccio(Animal altre)
    {

            return new Tortuga();
    }*/
}