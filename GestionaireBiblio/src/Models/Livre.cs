public class Livre
{
    private string ISBN;
    private string Titre;
    private List<string> Auteurs;
    private int AnneePublication;
    private string Genre;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isbn"></param>
    /// <param name="titre"></param>
    /// <param name="auteurs"></param>
    /// <param name="anneePublication"></param>
    /// <param name="genre"></param>
    public Livre(string isbn, string titre, List<string> auteurs, int anneePublication, string genre)
    {
        this.ISBN = isbn;
        this.Titre = titre;
        this.Auteurs = auteurs;
        this.AnneePublication = anneePublication;
        this.Genre = genre;
    }

    public void SetISBN(string isbn)
    {
        this.ISBN = isbn;
    }

    public string GetISBN()
    {
        return this.ISBN;
    }

    public void SetTitre(string titre)
    {
        this.Titre = titre;
    }

    public string GetTitre()
    {
        return this.Titre;
    }

    public void SetAuteurs(List<string> auteurs)
    {
        this.Auteurs = auteurs;
    }

    public List<string> GetAuteurs()
    {
        return this.Auteurs;
    }

    public void SetAnneePublication(int annee)
    {
        this.AnneePublication = annee;
    }

    public int GetAnneePublication()
    {
        return this.AnneePublication;
    }

    public void SetGenre(string genre)
    {
        this.Genre = genre;
    }

    public string GetGenre()
    {
        return this.Genre;
    }

    public void AjouterAuteur(string auteur)
    {
        this.Auteurs.Add(auteur);
    }

    public void SupprimerAuteur(string auteur)
    {
        this.Auteurs.Remove(auteur);
    }

    private void ValiderISBN()
    {
        // Logic to validate ISBN.
    }
}
