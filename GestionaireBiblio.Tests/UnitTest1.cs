using NUnit.Framework;
using System.Collections.Generic;

namespace GestionaireBiblio.Tests
{
    [TestFixture]
    public class Tests
    {
        private Livre _livre;

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
            Assert.AreEqual("123456789", isbn);
        }

        [Test]
        public void SetISBN_ShouldUpdateISBN()
        {
            // Act
            _livre.SetISBN("987654321");

            // Assert
            Assert.AreEqual("987654321", _livre.GetISBN());
        }

        [Test]
        public void AjouterAuteur_ShouldAddAuthorToList()
        {
            // Act
            _livre.AjouterAuteur("Auteur 2");

            // Assert
            Assert.Contains("Auteur 2", _livre.GetAuteurs());
        }

        [Test]
        public void SupprimerAuteur_ShouldRemoveAuthorFromList()
        {
            // Act
            _livre.SupprimerAuteur("Auteur 1");

            // Assert
            Assert.IsFalse(_livre.GetAuteurs().Contains("Auteur 1"));
        }

        [Test]
        public void GetAnneePublication_ShouldReturnCorrectYear()
        {
            // Act
            var annee = _livre.GetAnneePublication();

            // Assert
            Assert.AreEqual(2023, annee);
        }

        [Test]
        public void SetGenre_ShouldUpdateGenre()
        {
            // Act
            _livre.SetGenre("Science-fiction");

            // Assert
            Assert.AreEqual("Science-fiction", _livre.GetGenre());
        }
    }
}