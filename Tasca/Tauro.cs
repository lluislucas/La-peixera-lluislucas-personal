public class Tauro: Animal
{
    private static Random rPeix = new();
    public int RondaNaixament {get; set;}

    public ESexe Sexe {get; private set;}

    public Tauro((int x, int y) posicioInicial) : base(posicioInicial)
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

    public override void Interactuar(Animal altre, Peixera peixera)
    {
        
        if(altre is Peix p)
        {
            p.Morir();
        }

        if(altre is Tauro t)
        {
            if(Sexe == t.Sexe)
            {
                Morir();
                t.Morir();
            }
            else
            {
                Reproduccio(t,peixera);
                
            }
        
        }
    }

    public Animal Reproduccio(Tauro altreTauro, Peixera peixera)
    {
            (int x, int y) posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);

            while (posicioFill == this.Posicio || posicioFill == altreTauro.Posicio)
            {
                posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);
            }

            return new Tauro(posicioFill);
    }
    

    // public bool Morir(Animal animal)
    

    

    //conta rondes
}