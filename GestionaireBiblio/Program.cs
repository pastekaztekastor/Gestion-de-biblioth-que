internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le Gestionnaire de Bibliothèque!");

        // Exemple d'utilisation des classes et vues
        var livreView = new LivresView();
        //var emprunteurView = new EmprunteurView();

        // Exemple : Créer un nouvel emprunteur
        //var nouvelEmprunteur = emprunteurView.SaisirEmprunteur();

        // Exemple : Afficher un livre
        var auteurs = new List<string> { "George Orwell" };
        Livre livre = new Livre(
            isbn: "9780451524935",
            titre: "1984",
            auteurs: auteurs,
            anneePublication: 1949,
            genre: "Dystopie"
        );

        livreView.AfficherLivre(livre);

        // Fin du programme
        Console.WriteLine("Merci d'avoir utilisé le Gestionnaire de Bibliothèque !");
    }
}
