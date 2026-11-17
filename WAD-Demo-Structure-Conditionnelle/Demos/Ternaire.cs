namespace WAD_Demo_Structure_Conditionnelle.Demos
{
    // -- OPÉRATEUR TERNAIRE --  condition ? siVrai : siFaux
    // un if...else en une seule ligne pour ranger une valeur
    // (aussi vu dans la démo des opérateurs)
    internal static class Ternaire
    {
        public static void TernaireMajeurOuMineurDemo()
        {
            Console.WriteLine("-- ternaire --");

            int age = 16;

            //               condition ? SIVRAI : SIFAUX
            bool estMajeur = age >= 18 ? true : false;
            // astuce : age >= 18 donne déjà un bool, on pourrait écrire  bool estMajeur = age >= 18;

            //               condition ? SIVRAI : SIFAUX
            string statut = age >= 18 ? "Est majeur" : "Est mineur";

            Console.WriteLine($"est majeur : {estMajeur}, statut : {statut}");
            Console.WriteLine();
        }
    }
}
