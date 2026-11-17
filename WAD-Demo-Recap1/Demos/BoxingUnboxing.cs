namespace WAD_Demo_Recap1.Demos
{
    // -- BOXING / UNBOXING --
    // tout est objet
    internal static class BoxingUnboxing
    {
        public static void BoxingToutEstObjetDemo()
        {
            Console.WriteLine("-- boxing --");

            // on range un int et un string dans des object : pas besoin de cast
            object ageBoxe = 20;
            object prenomBoxe = "Léa";
            Console.WriteLine($"{prenomBoxe} a {ageBoxe} ans");
            Console.WriteLine();
        }

        public static void UnboxingAvecUnCastDemo()
        {
            Console.WriteLine("-- unboxing --");

            object prenomBoxe = "Léa";

            // pour le sortir de l'object, on doit dire à C# quel type c'est (cast)
            string prenom = (string)prenomBoxe;

            // et on peut le remettre dans un object
            object nouveauPrenomBoxe = prenom;
            Console.WriteLine($"prénom : {prenom}, de nouveau dans un object : {nouveauPrenomBoxe}");
            Console.WriteLine();
        }
    }
}
