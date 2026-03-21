namespace Tasca;

internal class Program
{
    static void Main(string[] args)
    {

         Peixera peixera = new();
  
         int num_peixM = 50;
         int num_peixF = 50;
         int num_tauroM =10;
         int num_tauroF =10;
         int num_tortuga =6;
         int num_pop = 15;
         int num_rondes = 100;

         

        for( int i = 0; i< num_peixM; i++)
        {
           
            Peix nemo = new Peix (ESexe.Mascle);
            (int x, int y) posicioInicial = peixera.EscollirPosicioInicialAnimal();
            peixera.Aquari[posicioInicial.x][posicioInicial.y].Add(nemo);
 
        }

        for( int i = 0; i< num_peixF; i++)
        {
           
            Peix dori = new Peix (ESexe.Femella);
            (int x, int y) posicioInicial = peixera.EscollirPosicioInicialAnimal();
            peixera.Aquari[posicioInicial.x][posicioInicial.y].Add(dori);
 
        }
        for( int i = 0; i< num_tauroM; i++)
        {
           
            (int x, int y) posicioInicial = peixera.EscollirPosicioInicialAnimal();
            peixera.Aquari[posicioInicial.x][posicioInicial.y].Add(new Tauro (ESexe.Mascle));
 
        }
        for( int i = 0; i< num_tauroF; i++)
        {

            (int x, int y) posicioInicial = peixera.EscollirPosicioInicialAnimal();
            peixera.Aquari[posicioInicial.x][posicioInicial.y].Add(new Tauro (ESexe.Femella));
 
        }
        for( int i = 0; i< num_tortuga; i++)
        {
 
            (int x, int y) posicioInicial = peixera.EscollirPosicioInicialAnimal();
            peixera.Aquari[posicioInicial.x][posicioInicial.y].Add(new Tortuga (ESexe.Aleatori));

        }
        //Console.WriteLine("prova");
        for( int i = 0; i< num_pop; i++)
        {
 
            (int x, int y) posicioInicial = peixera.EscollirPosicioInicialPop();
            peixera.Aquari[posicioInicial.x][posicioInicial.y].Add(new Pop ());

        }
        peixera.Imprimir();

        for( int i = 0; i< num_rondes; i++)
        {
        
        
        peixera.SeguentRonda();
        peixera.RestarVida();
        peixera.EliminarAnimals();

        //peixera.Imprimir();
        

        Console.WriteLine(" ");
        }
        peixera.Imprimir();
        peixera.EstocPeixera();




    }
}