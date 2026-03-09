namespace Tasca;

internal class Program
{
    static void Main(string[] args)
    {
         Random random = new Random();

         Simulacio Univers1 = new();

         Peixera Aquari = new();

        
         int num_peix = 10;
         int num_tauro =2;
         int num_tortuga =2;
         int num_pop = 2;

         for( int i = 0; i< num_peix; i++)
        {
           
            Peix nemo = new Peix (Aquari.escollirPosicioInicialAnimal(random));
            Console.WriteLine($"{nemo.Sexe} {nemo.Direccio} {nemo.Posicio}");
            
        }

        

    }
}