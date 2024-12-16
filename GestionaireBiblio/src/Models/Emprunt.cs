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
        if (dateRetour<dateSortie)
        {
            throw new Exception("La date de sortie est posterieure à celle d'entrer.");
        }
        else
        {
            this.ISBNLivre = isbnLivre;
            this.IDEmprunteur = idEmprunteur;
            this.DateSortie = dateSortie;
            this.DateRetour = dateRetour;
        }
    }

    public Emprunt(Livre livre, Emprunteur emprunteur)
    {
        this.ISBNLivre = livre.ISBN;
        this.IDEmprunteur = emprunteur.GetID();
        this.DateSortie = DateTime.Now;
        this.DateRetour = DateTime.MaxValue;
    }
    
    public void      EnregistrerRetour   ()                     {this.DateRetour = DateTime.Now;}

    public TimeSpan CalculerDureeEmprunt()
    {
        if (DateRetour < DateSortie)
        {
            throw new Exception("La date de sortie est posterieure à celle d'entrer.");
        }
        else
        {
            if (DateRetour == DateTime.MaxValue)
            {
                return DateTime.Now - DateSortie;
            }
            else
            {
                return DateRetour - DateSortie;
            }
        }
    }

    public Boolean EstRevenu()
    {
        if (DateRetour == DateTime.MaxValue)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
