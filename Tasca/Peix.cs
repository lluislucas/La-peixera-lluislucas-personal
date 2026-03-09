public class Peix : Animal
{
    private static Random rPeix = new();
  
    public   ESexe Sexe {get; set;}

    public Peix((int x, int y) posicioInicial) : base(posicioInicial)
    {
      
      EscullSexe();
    }

    public  void EscullSexe()
    {
        int numero = rPeix.Next(0,2);
        if(numero == 0)
        {
            this.Sexe = ESexe.Mascle;
            return;
            
        }
        
            this.Sexe = ESexe.Femella;

    }

    /*public  override bool EsPotReproduir(Animal altre)
    {
        
            return false;
    }*/

   public override void Interactuar(Animal altre,Peixera peixera)
    {
        if(altre is Tauro)
        {
            Morir();
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
                Reproduccio(p, peixera);
                
            }
        }
    }

  
       
    public Animal Reproduccio(Peix altrePeix, Peixera peixera)
    {
            (int x, int y) posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);

            while (posicioFill == this.Posicio || posicioFill == altrePeix.Posicio)
            {
                posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);
            }

            return new Peix(posicioFill);
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
