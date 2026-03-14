public class Tauro: Animal
{
    private static Random rPeix = new();
    public int Vides {get; set;}

    public Tauro(ESexe sexe) : base(sexe)
    {
      Vides = 50;
    }

   /* public override Animal? Interactuar(Animal altre, Peixera peixera)
    {
        
        if(altre is Peix p )
        {
            p.Morir();
            
        }
        else if(altre is Pop po )
        {
            po.Morir();
            
        }
        else if(altre is Tortuga )
        {
            CanvidireccioTauro();
        }
        else if(altre is Tauro t)
        {
            if(Sexe == t.Sexe)
            {
                Morir();
                t.Morir();
            }
            else
            {
                 return Reproduccio( );
                
            }
        
        }
        return null;
    }

    public override Animal Reproduccio(Animal altre, (int x, int y) MidaPeixera)
    {
            (int x, int y) posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);

            while (posicioFill == this.Posicio || posicioFill == altre.Posicio)
            {
                posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);
            }

            return new Tauro(posicioFill);
    }
    

    public void CompteEnrereMorTauro()
    {
        Vides -= 1;

        if(Vides == 0)
        {
            Morir();
        }
    }
    
    public void  CanvidireccioTauro()
    {

        int dx = r.Next(-1, 2);
        int dy = r.Next(-1, 2);
        

        while (dx == Direccio.dx && dy == Direccio.dy || dx == 0 && dy == 0)
        {
            dx = r.Next(-1, 2);
            dy = r.Next(-1, 2);
        }

        Direccio = (dx, dy);
        
    }*/

    
}