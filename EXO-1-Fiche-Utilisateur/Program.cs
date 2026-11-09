// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

// Créer une application console
// Dans cette application console :
// demander le prénom, le nom, l'âge et le numéro bancaire (sans BE)
// Afficher ensuite la fiche de l'utilisateur
// Afficher toutes les infos qu'il a écrites

Console.WriteLine("Quel est votre prénom ?");
string? prenom = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Quel est votre nom ?");
string? nom = Console.ReadLine();


Console.WriteLine("Quel est votre âge ?");
int age = int.Parse(Console.ReadLine()); // Je convertis "15" en 15
//bool estMajeur = bool.Parse("true");
//ERREUR : bool estMajeur = bool.Parse("salut ça va");

Console.WriteLine("Numéro de carte bancaire ?");
long numeroBancaire = long.Parse(Console.ReadLine());
    
Console.WriteLine("Fiche utilisateur");
Console.WriteLine($"Prénom : {prenom} ; Nom : {nom} ; Âge : {age} ; Numéro bancaire : {numeroBancaire}");