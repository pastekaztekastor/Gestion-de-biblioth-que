using System.Data;
using System.Text.Json.Serialization;

public class Emprunteur
{
    [JsonPropertyName("ID")]
    public int ID { get; set; } = 0;
    [JsonPropertyName("Nom")]
    public string Nom { get; set; } = string.Empty;
    [JsonPropertyName("Prenom")]
    public string Prenom { get; set; } = string.Empty;
    [JsonPropertyName("Mail")]
    public string Mail { get; set; } = string.Empty;

    public Emprunteur() { } // Constructeur sans paramètre pour la désérialisation

    public Emprunteur(int id, string nom, string prenom, string mail)
    {
        this.ID = id;
        this.Nom = nom;
        this.Prenom = prenom;
        this.Mail = mail;
    }

    public void    SetID       (int id)         {this.ID = id;}
    public void    SetNom      (string nom)     {this.Nom = nom;}
    public void    SetPrenom   (string prenom)  {this.Prenom = prenom;}
    public void    SetMail     (string mail)    {this.Mail = mail;}
    public int     GetID       ()               {return this.ID;}
    public string  GetNom      ()               {return this.Nom;}
    public string  GetPrenom   ()               {return this.Prenom;}
    public string  GetMail     ()               {return this.Mail;}
}
