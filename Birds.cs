namespace ams_aves
{
    public class Birds
    {
        public int Id {get;set;}
        public string? Name {get;set;}

        public virtual void Voar() 
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name+ " voando");
        }
    }
}

