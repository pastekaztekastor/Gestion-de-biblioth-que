public class Livre
{
    private string ISBN;
    private string Titre;
    private List<string> Auteurs;
    private int AnneePublication;
    private string Genre;

    public Livre(string isbn, string titre, List<string> auteurs, int anneePublication, string genre)
    {
        this.ISBN = isbn;
        this.Titre = titre;
        this.Auteurs = auteurs;
        this.AnneePublication = anneePublication;
        this.Genre = genre;
    }

// GET
    public string       GetISBN             ()                      {return this.ISBN;}
    public string       GetTitre            ()                      {return this.Titre;}
    public List<string> GetAuteurs          ()                      {return this.Auteurs;}
    public int          GetAnneePublication ()                      {return this.AnneePublication;}
    public string       GetGenre            ()                      {return this.Genre;}

// SET
    public void         SetISBN             (string isbn)           {this.ISBN = isbn;}
    public void         SetTitre            (string titre)          {this.Titre = titre;}
    public void         SetAuteurs          (List<string> auteurs)  {this.Auteurs = auteurs;}
    public void         SetAnneePublication (int annee)             {this.AnneePublication = annee;}
    public void         SetGenre            (string genre)          {this.Genre = genre;}

// Autre
    public void         AjouterAuteur       (string auteur)         {this.Auteurs.Add(auteur);}
    public void         SupprimerAuteur     (string auteur)         {this.Auteurs.Remove(auteur);}
}
