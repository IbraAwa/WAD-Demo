namespace WAD_Demo_Recap1.Demos
{
    // -- LE TYPE STRING --
    internal static class ChaineDeCaracteres
    {
        public static void ToStringMarcheSurToutesLesVariablesDemo()
        {
            Console.WriteLine("-- ToString() sur toutes les variables --");

            // Parlons du type string
            // toute variable est convertible avec ToString()
            int age = 18;
            Console.WriteLine(age.ToString());

            bool estBoursier = false;
            Console.WriteLine(estBoursier.ToString());
            Console.WriteLine();
        }

        public static void StringImmuableMaisLePlusEgalMarcheQuandMemeDemo()
        {
            Console.WriteLine("-- string immuable --");

            // un string est immuable
            // une variable non modifiable

            // pourtant
            string message = "Bonjour";

            message += " et bienvenue à l'université";

            Console.WriteLine(message);

            // pourquoi ça marche alors que la variable est immuable ?
            // Car C# crée une copie où il insère l'ancienne valeur + la nouvelle
            Console.WriteLine();
        }
    }
}
