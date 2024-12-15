internal class Emprunteur
{
    private int ID;
    private string Nom;
    private string Prenom;
    private string Mail;

    public Emprunteur(int id, string nom, string prenom, string mail)
    {
        this.ID = id;
        this.Nom = nom;
        this.Prenom = prenom;
        this.Mail = mail;
    }

    public void SetID(int id)
    {
        this.ID = id;
    }

    public int GetID()
    {
        return this.ID;
    }

    public void SetNom(string nom)
    {
        this.Nom = nom;
    }

    public string GetNom()
    {
        return this.Nom;
    }

    public void SetPrenom(string prenom)
    {
        this.Prenom = prenom;
    }

    public string GetPrenom()
    {
        return this.Prenom;
    }

    public void SetMail(string mail)
    {
        this.Mail = mail;
    }

    public string GetMail()
    {
        return this.Mail;
    }

    private bool ValiderEmail(string mail)
    {
        // Logic to validate email.
        return true;
    }
}
