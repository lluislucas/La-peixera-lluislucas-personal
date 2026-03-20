public  class Pop : Animal
{
    public static Random rPeix = new();

    //public (int x, int y) Posicio {get; private set;}

    public Pop( ) : base(ESexe.Hermafrodita)
    {

    }


    public   (int dx, int dy)  CanviarDireccioPop((int x, int y) posicioActual, (int x, int y)midaPeixera)
    {
        int maxX = midaPeixera.x-1;
        int maxY = midaPeixera.y-1;


        if (posicioActual.x == 0 && posicioActual.y< maxY)
        {
            return (0,1);
        }
        else if (posicioActual.x < maxX && posicioActual.y== maxY)
        {
            return (1,0);
        }
        else if (posicioActual.x == maxX && posicioActual.y >0 )
        {
            return (0,-1);
        }
       else if (posicioActual.x > 0 && posicioActual.y == 0)
        {
          return (-1,0);    
        }
        else
        {
            return (0,0);
        }
              
    }

    public void ActualitzarDireccioPop((int x, int y) posicioActual, (int x, int y)midaPeixera)
    {
        Direccio = CanviarDireccioPop(posicioActual, midaPeixera);
    }

    public override Animal? Reproduccio()
    {

            return null;
    }



}