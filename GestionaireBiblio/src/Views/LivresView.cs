public class LivresView
{

    private List<Livre> prtLivres;

    public LivresView(List<Livre> _prtLivres)
    {
        this.prtLivres = _prtLivres;
    }

    internal void AfficherLivre(Livre livre)
    {
        Console.WriteLine($"ISBN : {livre.ISBN}");
        Console.WriteLine($"Titre : {livre.Titre}");
        Console.WriteLine($"Auteurs : {livre.Auteurs}");
        Console.WriteLine($"Année de publication : {livre.AnneePublication}");
        Console.WriteLine($"Genre : {livre.Genre}");
    }

    internal void Home()
    {
        Console.WriteLine("[1] - Recherche");
        Console.WriteLine("[2] - Afficher livre");
        Console.WriteLine("[3] - Ajouter");
        Console.WriteLine("[4] - Retoure");
        char touche = Console.ReadKey().KeyChar;
        switch (touche)
        {
            case '1':
                // Recherche();
                break;
            case '2':
                // ListeLivre();
                break;
            case '3':
                // AjouterLivre();
                break;
            case '4':
                // retour
                break;
            default:
                Home();
                break;
        }
    }

}