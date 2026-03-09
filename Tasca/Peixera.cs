public class Peixera
{

/*
        -mida
        -llista Aquari
        -posicions
        -potser mètodes tipus afegir/eliminar animal
        -comprovar límits*/

    public (int X, int Y) MidaPeixera {get; private set;}

    public List<Animal> Aquari {get; private set;}

    public  Peixera()
    {
       MidaPeixera = (20,20);
       Aquari = new List<Animal>();
        
    }

    public  virtual (int x, int y) EscollirPosicioInicialAnimal (Random r1 )
    {
        int x = r1.Next(0,MidaPeixera.X);

        int y = r1.Next(0,MidaPeixera.Y);
       
        while(comprovarPosicio((x,y)) == false)
        {
             x = r1.Next(0,MidaPeixera.X);

             y = r1.Next(0,MidaPeixera.Y);
        }

        return (x,y);
        
    }

    public virtual bool comprovarPosicio((int x, int y) valor)
    {
        foreach (Animal a in Aquari)
        {
            if( a.Posicio == valor)
            {
                return false;
            }
        }

        return true;
    }

    public void EliminarAnimal(Animal animal)
    {
            animal.Morir();
            Aquari.Remove(animal);
    }
}