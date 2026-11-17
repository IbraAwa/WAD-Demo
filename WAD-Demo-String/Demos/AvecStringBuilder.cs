using System.Text;

namespace WAD_Demo_String.Demos
{
    // -- STRINGBUILDER --  Append
    // permet de concaténer des chaînes de caractères
    // sans créer de copie à chaque modification
    // (il faut ajouter : using System.Text; en haut du fichier)
    internal static class AvecStringBuilder
    {
        public static void AppendAjouteDuTexteSansCopieDemo()
        {
            Console.WriteLine("-- Append --");

            StringBuilder sb = new StringBuilder();

            // Append ajoute le texte à la suite, dans le même StringBuilder
            sb.Append("Le Seigneur des anneaux");
            sb.Append(" de J.R.R. Tolkien");

            Console.WriteLine(sb);
            Console.WriteLine();
        }

        public static void ToStringPourRecupererLeTexteFinalDemo()
        {
            Console.WriteLine("-- ToString pour récupérer le string --");

            StringBuilder ficheLivre = new StringBuilder();
            ficheLivre.Append("Titre : Harry Potter");
            ficheLivre.Append(" | Auteur : J.K. Rowling");
            ficheLivre.Append(" | Année : 1997");

            // un StringBuilder n'est pas un string
            // ToString() le transforme en string quand on a fini de construire le texte
            string texteFinal = ficheLivre.ToString();
            Console.WriteLine(texteFinal);
            Console.WriteLine();
        }
    }
}
