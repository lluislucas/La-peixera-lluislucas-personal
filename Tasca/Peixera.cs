public class Peixera
{

/*
        -mida
        -llista Aquari
        -posicions
        -potser mètodes tipus afegir/eliminar animal
        -comprovar límits*/

    protected static Random random = new();

    public (int X, int Y) MidaPeixera {get; private set;}

    public List<List<List<Animal>>> Aquari {get; private set;}

    public  Peixera()
    {
       MidaPeixera = (20,20);

       //zoo = list animal
       
       Aquari = new List<List<List<Animal>>>();

       for (int x = 0; x < MidaPeixera.X; x++)
        {
            Aquari.Add(new List<List<Animal>>());

            for (int y = 0; y < MidaPeixera.Y; y++)
            {
                Aquari[x].Add(new List<Animal>());
            }
        }
       
        
    }

    public  (int x, int y) EscollirPosicioInicialAnimal ( )
    {
        int x = random.Next(0,MidaPeixera.X);

        int y = random.Next(0,MidaPeixera.Y);
       
        while(comprovarPosicio((x,y)) == true)
        {
             x = random.Next(0,MidaPeixera.X);

             y = random.Next(0,MidaPeixera.Y);
        }


        return (x,y);
        
    }

    public  bool comprovarPosicio((int x, int y) valor)
    {
        Console.WriteLine("prova");
            if(Aquari[valor.x][valor.y].Count > 0)
            {
                return true;
            }
 
            return false;
    }

   /* public  Animal Reproduccio(Animal altre)
    {
            (int x, int y) posicioFill = EscollirPosicioInicialAnimal(random);

            while ( posicioFill == altre.Posicio)
            {
                posicioFill = EscollirPosicioInicialAnimal(random);
            }

            return new Peix(posicioFill);
    }

    public void AfegirAnimal(Animal animal)
    {
        Aquari.Add(animal);
    }


    public void EliminarAnimal(Animal animal)
    {
            animal.Morir();
            Aquari.Remove(animal);
    }*/

}