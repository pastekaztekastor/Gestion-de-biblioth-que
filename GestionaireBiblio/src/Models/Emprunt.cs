using System.Data;
using System.Text.Json.Serialization;

public class Emprunt
{
    [JsonPropertyName("ISBNLivre")]
    public string ISBNLivre { get; set; } = string.Empty; // Valeur par défaut

    [JsonPropertyName("IDEmprunteur")]
    public int IDEmprunteur { get; set; } = 0;

    [JsonPropertyName("DateSortie")]
    public DateTime DateSortie { get; set; } = DateTime.MinValue;

    [JsonPropertyName("DateRetour")]
    public DateTime DateRetour { get; set; } = DateTime.MinValue;

    public Emprunt() { } // Constructeur sans paramètre pour la désérialisation

    public Emprunt(string isbnLivre, int idEmprunteur, DateTime dateSortie, DateTime dateRetour)
    {
        this.ISBNLivre = isbnLivre;
        this.IDEmprunteur = idEmprunteur;
        this.DateSortie = dateSortie;
        this.DateRetour = dateRetour;
    }

    public Emprunt(Livre livre, Emprunteur emprunteur)
    {
        this.ISBNLivre = livre.GetISBN();
        this.IDEmprunteur = emprunteur.GetID();
        this.DateSortie = DateTime.Now;
        this.DateRetour = DateTime.MinValue;
    }

    public void      SetISBNLivre        (string isbnLivre)     {this.ISBNLivre = isbnLivre;}
    public void      SetDateSortie       (DateTime dateSortie)  {this.DateSortie = dateSortie;}
    public void      SetIDEmprunteur     (int idEmprunteur)     {this.IDEmprunteur = idEmprunteur;}
    public void      SetDateRetour       (DateTime dateRetour)  {this.DateRetour = dateRetour;}
    public string    GetISBNLivre        ()                     {return this.ISBNLivre;}
    public int       GetIDEmprunteur     ()                     {return this.IDEmprunteur;}
    public DateTime  GetDateSortie       ()                     {return this.DateSortie;}
    public DateTime  GetDateRetour       ()                     {return this.DateRetour;}



    public void EnregistrerRetour()
    {
        // Logic to register a book being returned.
    }

    private void CalculerDureeEmprunt()
    {
        // Logic to calculate the borrowing duration.
    }
}
