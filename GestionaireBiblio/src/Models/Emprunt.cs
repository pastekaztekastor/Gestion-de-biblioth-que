internal class Emprunt
{
    private string ISBNLivre;
    private int IDEmprunteur;
    private DateTime DateSortie;
    private DateTime DateRetour;

    public Emprunt(string isbnLivre, int idEmprunteur, DateTime dateSortie, DateTime dateRetour)
    {
        this.ISBNLivre = isbnLivre;
        this.IDEmprunteur = idEmprunteur;
        this.DateSortie = dateSortie;
        this.DateRetour = dateRetour;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isbnLivre"></param>
    public void SetISBNLivre(string isbnLivre)
    {
        this.ISBNLivre = isbnLivre;
    }

    public string GetISBNLivre()
    {
        return this.ISBNLivre;
    }

    public void SetIDEmprunteur(int idEmprunteur)
    {
        this.IDEmprunteur = idEmprunteur;
    }

    public int GetIDEmprunteur()
    {
        return this.IDEmprunteur;
    }

    public void SetDateSortie(DateTime dateSortie)
    {
        this.DateSortie = dateSortie;
    }

    public DateTime GetDateSortie()
    {
        return this.DateSortie;
    }

    public void SetDateRetour(DateTime dateRetour)
    {
        this.DateRetour = dateRetour;
    }

    public DateTime GetDateRetour()
    {
        return this.DateRetour;
    }

    public void EnregistrerSortie()
    {
        // Logic to register a book being borrowed.
    }

    public void EnregistrerRetour()
    {
        // Logic to register a book being returned.
    }

    private void CalculerDureeEmprunt()
    {
        // Logic to calculate the borrowing duration.
    }
}
