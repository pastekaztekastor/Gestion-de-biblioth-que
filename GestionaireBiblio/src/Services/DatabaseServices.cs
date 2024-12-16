using System;
using System.Text.Json;

namespace GestionaireBiblio.src.Services;

public class DatabaseServices
{
    /// LoadEmprunt
    public List<Emprunt> LoadEmprunt(String pathToJson)
    { 
        if (!File.Exists(pathToJson))
        {
            throw new FileNotFoundException($"Le fichier spécifié n'existe pas : {pathToJson}");
        }
        try
        {
            string jsonContent = File.ReadAllText(pathToJson);
            List<Emprunt> emprunts = JsonSerializer.Deserialize<List<Emprunt>>(jsonContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true 
            }) ?? new List<Emprunt>();
            return emprunts ?? new List<Emprunt>();
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Une erreur s'est produite lors du chargement des emprunts.", ex);
        }
    }
    /// LoadLivre
    public List<Livre> LoadLivre(String pathToJson)
    { // Vérifier si le fichier existe
        if (!File.Exists(pathToJson))
        {
            throw new FileNotFoundException($"Le fichier spécifié n'existe pas : {pathToJson}");
        }
        try
        {
            string jsonContent = File.ReadAllText(pathToJson);
            List<Livre> livres = JsonSerializer.Deserialize<List<Livre>>(jsonContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Permet d'ignorer la casse des noms de propriétés
            }) ?? new List<Livre>(); // Si null, initialiser une liste vide.
            return livres ?? new List<Livre>(); // Retourner une liste vide si null
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Une erreur s'est produite lors du chargement des livres.", ex);
        }
    }
    /// LoadEmprunteur
    public List<Emprunteur> LoadEmprunteur(String pathToJson)
    { // Vérifier si le fichier existe
        if (!File.Exists(pathToJson))
        {
            throw new FileNotFoundException($"Le fichier spécifié n'existe pas : {pathToJson}");
        }
        try
        {
            string jsonContent = File.ReadAllText(pathToJson);
            List<Emprunteur> emprunteurs = JsonSerializer.Deserialize<List<Emprunteur>>(jsonContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Permet d'ignorer la casse des noms de propriétés
            }) ?? new List<Emprunteur>(); // Si null, initialiser une liste vide.
            return emprunteurs ?? new List<Emprunteur>(); // Retourner une liste vide si null
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Une erreur s'est produite lors du chargement des emprunts.", ex);
        }
    }
    /// AddEmprunt
    /// AddLivre
    /// AddEmprunteur
}
