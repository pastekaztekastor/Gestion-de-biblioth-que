internal class LivresView
{
    public LivresView()
    {
    }

    internal void AfficherLivre(Livre livre)
    {
        Console.WriteLine($"ISBN : {livre.GetISBN()}");
        Console.WriteLine($"Titre : {livre.GetTitre()}");
        Console.WriteLine($"Auteurs : {livre.GetAuteurs()}");
        Console.WriteLine($"Année de publication : {livre.GetAnneePublication()}");
        Console.WriteLine($"Genre : {livre.GetGenre()}");
    }
}