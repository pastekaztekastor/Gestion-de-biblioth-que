using GestionaireBiblio.src.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le Gestionnaire de Bibliothèque!");

        // Chargement de la data
        DatabaseServices dbs = new DatabaseServices();
        List<Livre> livres = dbs.LoadLivre("../../../data/livres.json");
        List<Emprunt> emprunts = dbs.LoadEmprunt("../../../data/emprunt.json");
        List<Emprunteur> emprunteurs = dbs.LoadEmprunteur("../../../data/emprunteur.json");

        // Création de View

        // Fin du programme
        Console.WriteLine("Merci d'avoir utilisé le Gestionnaire de Bibliothèque !");
    }
}
