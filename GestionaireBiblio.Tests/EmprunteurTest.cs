using NUnit.Framework;

namespace GestionaireBiblio.Tests;

public class EmprunteurTest
{

    public Emprunteur? _emprunteur;
    [SetUp]
    public void Setup()
    {
        _emprunteur = new Emprunteur(
            0,
            "Nom",
            "Prénom",
            "mail"
        );
    }

    [Test]
    public void GetMethode_ShouldReturnCorrectValue()
    {
        Assert.That(_emprunteur.GetID(), Is.EqualTo(0));
        Assert.That(_emprunteur.GetNom(), Is.EqualTo("Nom"));
        Assert.That(_emprunteur.GetPrenom(), Is.EqualTo("Prénom"));
        Assert.That(_emprunteur.GetMail(), Is.EqualTo("mail"));
    }
    [Test]
    public void SetMethode_ShouldUpdateCorrectValue()
    {
        _emprunteur.SetID(1);
        _emprunteur.SetNom("Nom2");
        _emprunteur.SetPrenom("Prénom2");
        _emprunteur.SetMail("Mail2");

        Assert.That(_emprunteur.GetID(), Is.EqualTo(1));
        Assert.That(_emprunteur.GetNom(), Is.EqualTo("Nom2"));
        Assert.That(_emprunteur.GetPrenom(), Is.EqualTo("Prénom2"));
        Assert.That(_emprunteur.GetMail(), Is.EqualTo("Mail2"));
    }
}
