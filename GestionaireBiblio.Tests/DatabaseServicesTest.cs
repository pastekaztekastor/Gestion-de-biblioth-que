using NUnit.Framework;

namespace GestionaireBiblio.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using GestionaireBiblio.src.Services;
using NUnit.Framework;

[TestFixture]
public class EmpruntTests
{
    private string _tempFilePath = "";
    private DatabaseServices? _databaseServices;

    [SetUp]
    public void Setup()
    {
        // Crée un fichier temporaire pour les tests
        _tempFilePath = Path.GetTempFileName();
        _databaseServices = new DatabaseServices();

    }

    [TearDown]
    public void Teardown()
    {
        // Supprime le fichier temporaire après chaque test
        if (File.Exists(_tempFilePath))
        {
            File.Delete(_tempFilePath);
        }
    }

    [Test]
    public void LoadEmprunt_ValidJson_ReturnsEmpruntList()
    {
        // Arrange
        string validJson = @"
        [
            {
                ""ISBNLivre"": ""1234567890"",
                ""IDEmprunteur"": 1,
                ""DateSortie"": ""2024-12-15T10:30:00"",
                ""DateRetour"": ""2024-12-22T10:30:00""
            }
        ]";
        File.WriteAllText(_tempFilePath, validJson);

        // Act
        List<Emprunt> result = _databaseServices.LoadEmprunt(_tempFilePath);

        // Assert
        Assert.IsNotNull(result);
        Assert.That(result.Count, Is.EqualTo(1));
        Assert.That(result[0].ISBNLivre, Is.EqualTo("1234567890"));
        Assert.That(result[0].IDEmprunteur, Is.EqualTo(1));
        Assert.That(result[0].DateSortie, Is.EqualTo(new DateTime(2024, 12, 15, 10, 30, 0)));
        Assert.That(result[0].DateRetour, Is.EqualTo(new DateTime(2024, 12, 22, 10, 30, 0)));
    }

    [Test]
    public void LoadEmprunt_InvalidJson_ThrowsException()
    {
        // Arrange
        string invalidJson = "Invalid JSON Content";
        File.WriteAllText(_tempFilePath, invalidJson);

        // Act & Assert
        Assert.Throws<ApplicationException>(() => _databaseServices.LoadEmprunt(_tempFilePath));
    }

    [Test]
    public void LoadEmprunt_FileDoesNotExist_ThrowsFileNotFoundException()
    {
        // Arrange
        string nonExistentFilePath = "NonExistentFile.json";

        // Act & Assert
        Assert.Throws<FileNotFoundException>(() => _databaseServices.LoadEmprunt(nonExistentFilePath));
    }
}

