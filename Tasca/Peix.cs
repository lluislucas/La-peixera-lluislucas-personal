public class Peix : Animal
{
    private static Random rPeix = new();
  
    public Sexe Sex {get; set;}

    public Peix((int x, int y) posicio, Sexe sexe) : base(posicio)
    {
      Sex = sexe;
    }
    
    
    public Animal  Reproduccio()
    {
       
       new Peix((int x, int y) posicio, Sexe sexe) : base(posicio)
        {
             posicio = escollirPosicioInicialAnimal(r2);
        }
        
    }
    
    
}

/* 

if ( altre is Tauro)
{
        this.Matar()
}
if ( altre is Peix p)
{
    if(p.sexe == sexe)
    else
        criar()
}

*/
