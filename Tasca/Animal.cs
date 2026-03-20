public abstract class Animal
{
    protected static Random r = new();

    public (int dx, int dy) Direccio {get; protected set;}

    public bool EsViu {get; protected set;}

    public   ESexe Sexe {get; set;}

    public bool ShaMogut {get; set;}


    public Animal(ESexe sexe)
    {
      
      Direccio = direccioAnimal();
      EsViu = true;
      if(sexe== ESexe.Aleatori)
      {
      Sexe = EscullSexe();
      }
      else
        {
            Sexe = sexe;
        }
        ShaMogut = false;
        
    }

    public  virtual ESexe EscullSexe()
    {
        int numero = r.Next(0,2);
        if(numero == 0)
        {
            
            return ESexe.Mascle;
            
        }
        
            return ESexe.Femella;

    }
  

    public virtual  (int dx, int dy) direccioAnimal ()
    {
        int dx = r.Next(-1, 2);
        int dy = r.Next(-1, 2);

        while (dx == 0 && dy == 0)
        {
            dx = r.Next(-1, 2);
            dy = r.Next(-1, 2);
        }

        return (dx, dy);
        
    }

   public virtual (int x, int y) ObtenirSeguentPosicio((int x, int y)posicio ,(int x, int y) midapeixera)
    {
        
         (int x, int y) PosicioFinal = ((posicio.x + Direccio.dx + midapeixera.x) % midapeixera.x, (posicio.y + Direccio.dy + midapeixera.y) % midapeixera.y );

          return PosicioFinal;
        
    }


    public void Morir()
    {
        EsViu = false;
    }

    public abstract Animal Reproduccio();
    
    
}