namespace ams_aves
{
    class Program
    {
        static void Main(string[]args)
        {
            Birds aguia = new fly(222,"águia real");
            aguia.Voar();

            Birds pinguim = new Notfly(333,"pinguim imperador");
            pinguim.Voar();
        }
    }
}