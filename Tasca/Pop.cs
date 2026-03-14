public  class Pop : Animal
{
    public static Random rPeix = new();

    //public (int x, int y) Posicio {get; private set;}

    public (int dx, int dy) Direccio {get; private set;}

    public bool EsViu {get; private set;}

    public Pop( ) : base(ESexe.Hermafrodita)
    {
      
      EsViu = true;
      //Direccio = CanviarDireccioPop();

    }
    
   /* public  override (int x, int y) EscollirPosicioInicialAnimal(Animal altre, Random r1, (int x, int y) MidaPeixera)
    {
        int[] lateral ={0,19};

        (int x,int y)[] Posicions = {(r1.Next(20),lateral[r1.Next(1)]),(lateral[r1.Next(1)],r1.Next(20))}; 
        
        return Posicions[r1.Next(2)];

    }
    public override Animal? Interactuar(Animal altre,Peixera peixera)
    {
        if(altre is Pop)
        {
            Morir();
            return null;
        }

        if(altre is Pop p)
        {
            if(Sexe == p.Sexe)
            {
                Morir();
                p.Morir();
                
            }
            else
            {
            
                
            }
        }
        return null;
    }

    public   (int dx, int dy)  CanviarDireccioPop()
    {

        if (Posicio == (0,0))
        {
            return (0,1);
        }
        else if (Posicio == (19,0))
        {
            return (1,0);
        }
        else if (Posicio == (19,19))
        {
            return (0,-1);
        }
       else
            return (-1,0);    
    }


    public virtual void MourePop()
    {
        
        Posicio = (Posicio.x + Direccio.dx, Posicio.y + Direccio.dy);
        
    }

    public void DinarGallec()
    {
        EsViu = false;
    }

    public override Animal? Reproduccio(Animal altre, Peixera peixera)
    {
        return null;
    }*/


}