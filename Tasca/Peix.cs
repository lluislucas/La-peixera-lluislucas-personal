public class Peix : Animal
{
    private static Random rPeix = new();
  
    public Peix(ESexe sexe) : base(sexe)
    {
      
    }

   /*public override Animal? Interactuar(Animal altre)
    {
        if(altre is Tauro)
        {
            Morir();
            return null;
        }

        if(altre is Peix p)
        {
            if(Sexe == p.Sexe)
            {
                Morir();
                p.Morir();
                
            }
            else
            {
                return Reproduccio( );
                
            }
        }
        return null;
    }

*/
    
        
}
    

