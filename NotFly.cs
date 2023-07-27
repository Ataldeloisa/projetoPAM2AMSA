namespace ams_aves
{
    public class Notfly : Birds
    {
        public Notfly (int id,string? name)
        {
            this.Id=id;
            this.Name=name;
        }
        public override void Voar()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name+" nao vooa");
        }
    }
}
