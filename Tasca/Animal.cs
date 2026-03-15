public abstract class Animal
{
    protected static Random r = new();

    //public (int x, int y) Posicio {get; protected set;}

    public (int dx, int dy) Direccio {get; protected set;}

    public bool EsViu {get; protected set;}

    public   ESexe Sexe {get; set;}

    public bool ShaMogut {get; set;}

    public Animal(ESexe sexe)
    {
      
      //Posicio = EscollirPosicioInicialAnimal();
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

    public  ESexe EscullSexe()
    {
        int numero = r.Next(0,2);
        if(numero == 0)
        {
            this.Sexe = ESexe.Mascle;
            return ESexe.Mascle;
            
        }
        
            this.Sexe = ESexe.Femella;
            return ESexe.Femella;

    }

    //public abstract Animal? Reproduccio(Animal altre, (int x, int y) MidaPeixera);
  

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
        
         (int x, int y) PosicioFinal = ((posicio.x + Direccio.dx) % midapeixera.x, (posicio.y + Direccio.dy) % midapeixera.y );

          return PosicioFinal;
        
    }


    /*public void Morir()
    {
        EsViu = false;
    }

    public abstract Animal? Interactuar(Animal altre);


    public virtual (int x, int y) EscollirPosicioInicialAnimal ( Random r1, (int x, int y) MidaPeixera )
    {
        int x = r1.Next(0,MidaPeixera.x);

        int y = r1.Next(0,MidaPeixera.y);

        return (x,y);
        
    }

    public override Animal Reproduccio(Animal altre)//if per combropbar si es hermafrodita
    {
            (int x, int y) posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);

            while ( posicioFill == altre.Posicio)
            {
                posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);
            }

            return new Tauro();

    }*/
    

    
}