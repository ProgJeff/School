namespace Demo_structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne UnePersonne = new Personne();
            LigneFacture ligneFacture = new LigneFacture();

            UnePersonne.Age = 50;
            UnePersonne.FirstName = "Jeff";
            UnePersonne.Name = "Marceau";
            Console.WriteLine(UnePersonne.Name);
            Console.WriteLine(UnePersonne.FirstName);
            Console.Write(UnePersonne.Age);
        }
    }
}