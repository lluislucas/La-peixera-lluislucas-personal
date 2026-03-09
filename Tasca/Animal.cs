public abstract class Animal
{
    protected static Random r = new();
    public (int x, int y) Posicio {get; protected set;}

    public (int dx, int dy) Direccio {get; protected set;}

    public bool EsViu {get; protected set;}

    public Animal((int x, int y) posicioInicial)
    {
      
      Posicio = posicioInicial;
      Direccio = direccioAnimal();
      EsViu = true;

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


    public virtual void MoureAnimal()
    {
        
        Posicio = (Posicio.x +Direccio.dx, Posicio.y +Direccio.dy);
        
    }

    public void Morir()
    {
        EsViu = false;
    }

   /* public virtual bool EsPotReproduir(Animal altre)
    {
            return false;
    }*/

    public abstract void Interactuar(Animal altre, Peixera peixera);

    
}