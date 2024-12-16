using NUnit.Framework;

namespace GestionaireBiblio.Tests;

public class EmpruntTest
{
    public Emprunt? _emprunt;
    [SetUp]
    public void Setup()
    {
        _emprunt = new Emprunt(
            "isbn",
            123456,
            new DateTime(2024, 12, 25, 18, 30, 0),
            new DateTime(2025, 12, 25, 18, 30, 0)
        );
    }

    [Test]
    public void GetMethode_ShouldReturnCorrectValue()
    {
        Assert.That(_emprunt.GetISBNLivre(), Is.EqualTo("isbn"));
        Assert.That(_emprunt.GetIDEmprunteur(), Is.EqualTo(123456));
        Assert.That(_emprunt.GetDateSortie(), Is.EqualTo(new DateTime(2024, 12, 25, 18, 30, 0)));
        Assert.That(_emprunt.GetDateRetour(), Is.EqualTo(new DateTime(2025, 12, 25, 18, 30, 0)));
    }

    [Test]
    public void SetMethode_ShouldUpdateCorrectValue()
    {
        _emprunt.SetISBNLivre("isbn2");
        _emprunt.SetIDEmprunteur(234567);
        _emprunt.SetDateSortie(new DateTime(2026, 12, 25, 18, 30, 0));
        _emprunt.SetDateRetour(new DateTime(2027, 12, 25, 18, 30, 0));

        Assert.That(_emprunt.GetISBNLivre(), Is.EqualTo("isbn2"));
        Assert.That(_emprunt.GetIDEmprunteur(), Is.EqualTo(234567));
        Assert.That(_emprunt.GetDateSortie(), Is.EqualTo(new DateTime(2026, 12, 25, 18, 30, 0)));
        Assert.That(_emprunt.GetDateRetour(), Is.EqualTo(new DateTime(2027, 12, 25, 18, 30, 0)));
    
    }
    [Test]
    public void Constructeur()
    {
        Livre? livre = new Livre("isbn", "titre", new List<string> { "Auteur 1" }, 2023, "Roman");
        Emprunteur? emprunteur = new Emprunteur(1, "nom", "prénom", "mail");

        Emprunt? emprunt = new Emprunt(livre, emprunteur);

        Assert.That(emprunt.GetISBNLivre(), Is.EqualTo("isbn"));
        Assert.That(emprunt.GetIDEmprunteur(), Is.EqualTo(1));
        Assert.That(emprunt.GetDateRetour(), Is.EqualTo(DateTime.MinValue));
    }
}
