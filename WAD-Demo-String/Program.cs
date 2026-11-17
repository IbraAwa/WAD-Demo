// === LES STRING ===

// un string c'est du texte (une chaîne de caractères)
// il a une particularité importante : il est immuable

// imaginons mon programme gère les livres d'une bibliothèque

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo_String.Demos;

// ==============================================
// STRING IMMUABLE                   (Immuable.cs)
// ==============================================
Console.WriteLine("===== STRING IMMUABLE =====");
Immuable.PlusEgalCreeUnNouveauStringDemo();
Immuable.PreuveLeStringDOrigineNeChangePasDemo();

// ==============================================
// STRINGBUILDER  Append             (AvecStringBuilder.cs)
// ==============================================
Console.WriteLine("===== STRINGBUILDER =====");
AvecStringBuilder.AppendAjouteDuTexteSansCopieDemo();
AvecStringBuilder.ToStringPourRecupererLeTexteFinalDemo();
