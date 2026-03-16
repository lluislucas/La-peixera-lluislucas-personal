public class Peix : Animal
{
    private static Random rPeix = new();
  
    public Peix(ESexe sexe) : base(sexe)
    {
      
    }

   public override bool? Interactuar(Animal altre)
    {
        if(altre is Tauro)
        {
            
            return false;
        }

        if(altre is Peix p)
        {
            if(Sexe == p.Sexe)
            {
                return false;
                
            }
            else
            {
                return true;
                
            }
        }
        return null;
    }

    

        
}
    

