public class Peix : Animal
{
    private static Random rPeix = new();
  
    public   ESexe Sexe {get; set;}

    public Peix((int x, int y) posicioInicial) : base(posicioInicial)
    {
      
      escullSexe();
    }

    public virtual void escullSexe()
    {
        int numero = rPeix.Next(0,2);
        if(numero == 0)
        {
            this.Sexe = ESexe.Mascle;
            return;
            
        }
        
            this.Sexe = ESexe.Femella;

    }
    
    
    /*public Animal  Reproduccio()
    {
       
       new Peix((int x, int y) posicio, Sexe sexe) : base(posicio)
        {
             posicio = escollirPosicioInicialAnimal(r2);
        }
        
    }*/
    
    
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
