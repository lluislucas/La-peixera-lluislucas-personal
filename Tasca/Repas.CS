public abstract class Animal 
{
    protected string Nom {get;}
    protected (int x, int y) Posicio {get; set;}
    protected bool EsViu {get; set;}

    public Animal (string nom, (int x, int y) posicio ):
    {
        Nom = nom;
        Posicio = posicio;
        EsViu = true;
    }

    public virtual void (int x, int y) Mou (Animal animal)
    {
        animal.Posicio.x =

        animal.Posicio.y = 
    }
}