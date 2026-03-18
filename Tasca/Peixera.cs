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

    public int Densitat = 50;

    public List<List<List<Animal>>> Aquari {get; private set;}

    

    public  Peixera()
    {
       MidaPeixera = (20,20);

       
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

   public  Animal Reproduccio((int x , int y ) Aquari)
    {
            (int x, int y) posicioFill = EscollirPosicioInicialAnimal();

            while ( posicioFill.x == Aquari.x && posicioFill.y == Aquari.y)
            {
                posicioFill = EscollirPosicioInicialAnimal();
            }

            return new Peix(ESexe.Aleatori);
    }

    public void AfegirAnimal(Animal animal)
    {
        Aquari[x][y].Add(animal);
    }


    public void EliminarAnimal(Animal animal)
    {
            animal.Morir();
            Aquari[x][y].Remove(animal);
    }

    public  void Imprimir()
    {
        for (int x = 0; x < MidaPeixera.X; x++)
        {
            for (int y = 0; y < MidaPeixera.Y; y++)
            {
                if(Aquari[x][y].Count>0)
                {
                    if(Aquari[x][y].Count <10)
                    {
                        Console.Write(0);
                    }
                  
                    Console.Write(Aquari[x][y].Count + " ");
                    
                }
                else
                {
                    Console.Write("__ ");
                }
            }
            Console.WriteLine();
        }
    }

    public void SeguentRonda()
    {
        ResetRonda();
        MoureTotsPeixos();
        for(int i =0; i<Aquari.Count; i++ )
        {
            for(int j =0; j<Aquari[i].Count; j++ )
            {
                for(int k =0; k<Aquari[i][j].Count; k++ )
                {
                    for(int l =k+1; l<Aquari[i][j].Count; l++ )
                    {
                        
                        Aquari[i][j][l].Interactuar(Aquari[i][j][k]);
                        //matar si ESVIU=false
                        
                        
                    }
                    

                }

            }
            
        }
        


        
    }

    public void MoureAnimal((int x, int y, int num_animal) GPSAnimal)
    {
        if(Aquari[GPSAnimal.x][GPSAnimal.y][GPSAnimal.num_animal].ShaMogut == false)
        {
            (int x, int y ) NovaPosicio =
            Aquari[GPSAnimal.x][GPSAnimal.y][GPSAnimal.num_animal].
            ObtenirSeguentPosicio((GPSAnimal.x,GPSAnimal.y),MidaPeixera);

            Aquari[GPSAnimal.x][GPSAnimal.y][GPSAnimal.num_animal].ShaMogut = true;

            Aquari[NovaPosicio.x][NovaPosicio.y].Add(Aquari[GPSAnimal.x][GPSAnimal.y][GPSAnimal.num_animal]);

            Aquari[GPSAnimal.x][GPSAnimal.y].RemoveAt(GPSAnimal.num_animal);
            
        }
   
    }

    public void MoureTotsPeixos()
    {
        for(int i =0; i<Aquari.Count; i++ )
        {
            for(int j =0; j<Aquari[i].Count; j++ )
            {
                for(int k =0; k<Aquari[i][j].Count; k++ )
                {
                    MoureAnimal((i,j,k));

                }

            }
            
        }
    }

    public void ResetRonda()
    {
        for(int i =0; i<Aquari.Count; i++ )
        {
            for(int j =0; j<Aquari[i].Count; j++ )
            {
                for(int k =0; k<Aquari[i][j].Count; k++ )
                {
                  
                    Aquari[i][j][k].ShaMogut= false;
            
                }

            }
            
        }
        
    }


}