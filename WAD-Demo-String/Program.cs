
// String est immuable
// ça veut dire quu'ne variable de type string est pas modifiable


// on a crée une variable title
using System.Text;

string title = "Seigneur des anneaux";

// on a ajouté un texte qui à sans le savoir crée 
// une nouvelle variable avec l'ancien texte + le nouveau
title += " nouvelle valeur";

Console.WriteLine(title);
Console.WriteLine();

// permet de concaténer des chaine de caractère
// sans crée de copy a chaque modification
StringBuilder sb = new StringBuilder();

sb.Append("nouveau texte");
sb.Append(" encore un nouveau texte");

Console.WriteLine(sb);