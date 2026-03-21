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

    public  (int x, int y) EscollirPosicioInicialAnimal ()
    { 
        
        int x = random.Next(0,MidaPeixera.X);

        int y = random.Next(0,MidaPeixera.Y);
       
        while(EsPosicioOcupada((x,y)) == true)
        {
             x = random.Next(0,MidaPeixera.X);

             y = random.Next(0,MidaPeixera.Y);
        }
            return (x,y);
     
    }
    public  (int x, int y) EscollirPosicioInicialPop()
    {
        int[] lateral ={0,MidaPeixera.X-1};
        (int x, int y) posicio;

        do{

        (int x,int y)[] Posicions = {(random.Next(MidaPeixera.X),lateral[random.Next(2)]),(lateral[random.Next(2)],random.Next(MidaPeixera.Y))}; 
        
        posicio =  Posicions[random.Next(2)];} while(EsPosicioOcupada(posicio));

        return posicio;

    }

    public  bool EsPosicioOcupada((int x, int y) valor)
    {
        
            if(Aquari[valor.x][valor.y].Count > 0)
            {
                return true;
            }
 
            return false;
    }

    public void Interactuar(Animal animal1, Animal animal2, (int x, int y)casellaPeixera)
    {
        if(animal1.EsViu==false || animal2.EsViu== false)
        {
            return;
        }

        if(animal1.GetType()  == animal2.GetType() )
        {
            if(animal1 is Pop pop1 && animal2 is Pop pop2)
            {
                pop1.ActualitzarDireccioPop(casellaPeixera,MidaPeixera);
                pop2.ActualitzarDireccioPop(casellaPeixera,MidaPeixera);
                return;
            }

            else if(animal1.Sexe == animal2.Sexe)
            {
                animal1.Morir(); 
                animal2.Morir();
            }
            else if (animal1 is not Pop)
            {
                
                    Animal? fill= animal1.Reproduccio();
                    if (fill != null)
                    {
                    fill.escullDireccioFill(animal1.Direccio,animal2.Direccio);
                    ColocarFill(fill, casellaPeixera);
                    }
                    
            }
            return;
        }
        
        else
        {
            if(animal1 is Tauro tauro)
            {
                if(animal2 is Peix)
                {
                    animal2.Morir();
                }
                else if(animal2 is Tortuga)
                {
                   
                    tauro.CanvidireccioTauro();
                    
                }
                else if(animal2 is Pop)
                {
                    animal2.Morir();
                }
                
            }
            else if(animal2 is Tauro tauro2)
            {
                if(animal1 is Peix)
                {
                    animal1.Morir();
                }
                else if(animal1 is Tortuga)
                {
                   
                    tauro2.CanvidireccioTauro();
                    
                }
                else if(animal1 is Pop)
                {
                    animal1.Morir();
                }
                
            }
            
        }
  
    }

   public  void ColocarFill(Animal fill, (int x , int y ) casellaPares)
    {
            (int x, int y) posicioFill = EscollirPosicioInicialAnimal();

            while ( posicioFill == casellaPares)
            {
                posicioFill = EscollirPosicioInicialAnimal();
            }

           Aquari[posicioFill.x][posicioFill.y].Add(fill);
    }

    public void SeguentRonda()
    {
        ResetRonda();
        MoureTotsAnimals();
        for(int i =0; i<Aquari.Count; i++ )
        {
            for(int j =0; j<Aquari[i].Count; j++ )
            {
                for(int k =0; k<Aquari[i][j].Count; k++ )
                {
                    for(int l =k+1; l<Aquari[i][j].Count; l++ )
                    {
                        
                        Interactuar(Aquari[i][j][l], Aquari[i][j][k], (i,j));
                    
                           
                    }   

                }

            }
            
        }

    }

    public void MoureAnimal((int x, int y, int num_animal) GPSAnimal)
    {
        Animal animal = Aquari[GPSAnimal.x][GPSAnimal.y][GPSAnimal.num_animal];
        if (animal is Pop pop)
        {
            pop.ActualitzarDireccioPop ((GPSAnimal.x,GPSAnimal.y),MidaPeixera);
        }

        if(animal.ShaMogut == false)
        {
            (int x, int y ) NovaPosicio =
                animal.ObtenirSeguentPosicio((GPSAnimal.x,GPSAnimal.y),MidaPeixera);

            animal.ShaMogut = true;

            Aquari[NovaPosicio.x][NovaPosicio.y].Add(animal);

            Aquari[GPSAnimal.x][GPSAnimal.y].RemoveAt(GPSAnimal.num_animal);
            
        }
   
    }

    public void MoureTotsAnimals()
    {
        for(int i =0; i<Aquari.Count; i++ )
        {
            for(int j =0; j<Aquari[i].Count; j++ )
            {
                for(int k =Aquari[i][j].Count-1; k>=0; k-- )
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

    public void RestarVida()
    {
        for(int i =0; i< Aquari.Count; i++ )
        {
            for(int j =0; j<Aquari[i].Count; j++ )
            {
                for(int k =0; k<Aquari[i][j].Count; k++ )
                {
                    if(Aquari[i][j][k] is Tauro tauro)
                    {
                        tauro.CompteEnrereMor();
                    }
                }
            }
        }
    }

    public void EliminarAnimals()
    {
        for(int i =0; i< Aquari.Count; i++ )
        {
            for(int j =0; j<Aquari[i].Count; j++ )
            {
                for(int k =Aquari[i][j].Count-1; k>=0; k-- )
                {
                    if (Aquari[i][j][k].EsViu == false)
                    {
                        Aquari[i][j].RemoveAt(k);
                    }

                }
            }
        }
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

    public void EstocPeixera()
    {
         int num_peixos = 0;
         int num_taurons =0;
         int num_tortugues =0;
         int num_pops = 0;

        for(int i =0; i< MidaPeixera.Y; i++ )
        {
            for(int j =0; j<MidaPeixera.X; j++ )
            {
                for(int k =0; k<Aquari[i][j].Count; k++ )
                {
                    if(Aquari[i][j][k] is Peix )
                    {
                        num_peixos+= 1;
                    }
                    else if(Aquari[i][j][k] is Tauro )
                    {
                        num_taurons+= 1;
                    }
                     else if(Aquari[i][j][k] is Tortuga )
                    {
                        num_tortugues+= 1;
                    }
                     else 
                    {
                        num_pops+= 1;
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Peixos: " + num_peixos);
        Console.WriteLine("Taurons: " + num_taurons);
        Console.WriteLine("Tortugues: " + num_tortugues);
        Console.WriteLine("Pops: " + num_pops);
    }

}