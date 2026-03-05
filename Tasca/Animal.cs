public abstract class Animal
{
    protected static Random r = new();
    protected (int x, int y) Posicio {get; private set;}

    protected (int dx, int dy) Direccio {get; private set;}

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

    public virtual void direccioDiferent()
    {
        
    }

    public virtual void MoureAnimal()
    {
        
        Posicio.x = Posicio.x +Direccio.dx;
        Posicio.y = Posicio.y +Direccio.dy;

        
    }




    
}