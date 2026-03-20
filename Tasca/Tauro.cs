public class Tauro: Animal
{
    private static Random rPeix = new();
    public int Vides {get; set;}

    public Tauro(ESexe sexe) : base(sexe)
    {
      Vides = 75;
      girarAmb = new(){"Tortuga"};
      potAtacar = new(){"Peix","Pop"};
    }

    public override Animal Reproduccio()
    {

            return new Tauro((ESexe.Aleatori));
    }



    public void CompteEnrereMor()
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
        

        while ((dx == Direccio.dx && dy == Direccio.dy) || (dx == 0 && dy == 0))
        {
            dx = r.Next(-1, 2);
            dy = r.Next(-1, 2);
        }

        Direccio = (dx, dy);
        
    }

    
}