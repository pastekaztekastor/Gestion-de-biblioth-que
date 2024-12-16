using System.Data;
using System.Text.Json.Serialization;
public class Livre
{

    [JsonPropertyName("ISBN")]
    public string ISBN { get; set; } = string.Empty; // Valeur par défaut
    [JsonPropertyName("Titre")]
    public string Titre { get; set; } = string.Empty; // Valeur par défaut
    [JsonPropertyName("Auteurs")]
    public List<string> Auteurs { get; set; } = new List<String>(); // Valeur par défaut
    [JsonPropertyName("AnneePublication")]
    public int AnneePublication { get; set; } = 0; // Valeur par défaut
    [JsonPropertyName("Genre")]
    public string Genre { get; set; } = string.Empty; // Valeur par défaut 

    public Livre() { } // Constructeur sans paramètre pour la désérialisation

    public Livre(string isbn, string titre, List<string> auteurs, int anneePublication, string genre)
    {
        this.ISBN = isbn;
        this.Titre = titre;
        this.Auteurs = auteurs;
        this.AnneePublication = anneePublication;
        this.Genre = genre;
    }

// Autre
    public void         AjouterAuteur       (string auteur)         {this.Auteurs.Add(auteur);}
    public void         SupprimerAuteur     (string auteur)         {this.Auteurs.Remove(auteur);}
}
