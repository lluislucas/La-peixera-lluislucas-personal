public abstract class Animal
{
    protected static Random r = new();
    public (int x, int y) Posicio {get; private set;}

    public (int dx, int dy) Direccio {get; private set;}

    public bool EsViu {get; private set;}

    public Animal((int x, int y) posicioInicial)
    {
      
      Posicio = posicioInicial;
      Direccio = direccioAnimal();
      EsViu = true;

    }
    
    protected (int dx, int dy) direccioAnimal ()
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

    
}