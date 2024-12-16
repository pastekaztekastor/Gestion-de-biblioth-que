using NUnit.Framework;
using System.Collections.Generic;

namespace GestionaireBiblio.Tests
{
    [TestFixture]
    public class LivresTests
    {
        private Livre? _livre;

        [SetUp]
        public void Setup()
        {
            _livre = new Livre("123456789", "Mon Livre", new List<string> { "Auteur 1" }, 2023, "Roman");
        }

        [Test]
        public void GetISBN_ShouldReturnCorrectISBN()
        {
            // Arrange : l'objet Livre est déjà initialisé dans SetUp
            // Act
            var isbn = _livre.GetISBN();
            // Assert
            Assert.That(isbn,Is.EqualTo("123456789"));
        }

        [Test]
        public void GetTitre_ShouldReturnCorrectTitre()
        {
            var titre = _livre.GetTitre();
            Assert.That(titre,Is.EqualTo("Mon Livre"));
        }

        [Test]
        public void GetAnneePublication_ShouldReturnCorrectYear()
        {
            var annee = _livre.GetAnneePublication();
            Assert.That(annee,Is.EqualTo(2023));
        }

        [Test]
        public void GetGenre_ShouldReturnCorrectGenre()
        {
            var genre = _livre.GetGenre();
            Assert.That(genre,Is.EqualTo("Roman"));
        }

        [Test]
        public void SetISBN_ShouldUpdateISBN()
        {
            _livre.SetISBN("987654321");
            Assert.That(_livre.GetISBN(),Is.EqualTo("987654321"));
        }

        [Test]
        public void SetTitre_ShouldUpdateTitre()
        {
            _livre.SetTitre("Mon Livre");
            Assert.That(_livre.GetTitre(),Is.EqualTo("Mon Livre"));
        }

        [Test]
        public void SetAuteurs_ShouldUpdateAuteursList()
        {
            // Arrange
            var auteurs = new List<string> { "George Orwell" };

            // Act
            _livre.SetAuteurs(auteurs);

            // Assert
            Assert.That(_livre.GetAuteurs(), Is.EqualTo(new List<string> { "George Orwell" }));
            Assert.That(_livre.GetAuteurs(), Does.Contain("George Orwell"));
            Assert.That(_livre.GetAuteurs().Count, Is.EqualTo(1));
        }

        [Test]
        public void SetGenre_ShouldUpdateGenre()
        {
            _livre.SetGenre("Science-fiction");
            Assert.That(_livre.GetGenre(),Is.EqualTo("Science-fiction"));
        }

        [Test]
        public void SetAnneePublication_ShouldUpdateAnneePublication()
        {
            _livre.SetAnneePublication(1234);
            Assert.That(_livre.GetAnneePublication(),Is.EqualTo(1234));
        }

        [Test]
        public void AjouterAuteur_ShouldAddAuthorToList()
        {
            _livre.AjouterAuteur("Auteur 2");
            Assert.Contains("Auteur 2", _livre.GetAuteurs());
        }

        [Test]
        public void SupprimerAuteur_ShouldRemoveAuthorFromList()
        {
            _livre.SupprimerAuteur("Auteur 1");
            Assert.IsFalse(_livre.GetAuteurs().Contains("Auteur 1"));
        }
    }
}