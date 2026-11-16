namespace WAD_Demo_Operateur.Demos
{
    // -- COMPARAISON --  == != < > <= >=
    // déjà vu dans la démo des conditions
    // une comparaison donne TOUJOURS un bool (true ou false)
    internal static class Comparaison
    {
        public static void EgalEgalPourComparerDemo()
        {
            Console.WriteLine("-- égal (==) --");

            // == pour comparer, = pour ranger
            int age = 20;
            bool aVingtAns = age == 20; // true
            Console.WriteLine($"20 == 20 : {aVingtAns}");
            Console.WriteLine();
        }

        public static void DifferentDemo()
        {
            Console.WriteLine("-- différent (!=) --");

            int age = 20;
            bool pasVingtAns = age != 20; // false
            Console.WriteLine($"20 != 20 : {pasVingtAns}");
            Console.WriteLine();
        }

        public static void StrictementPlusGrandDemo()
        {
            Console.WriteLine("-- strictement plus grand (>) --");

            // strictement = l'égalité ne compte pas
            Console.WriteLine($"20 > 18 : {20 > 18}"); // true
            Console.WriteLine($"18 > 18 : {18 > 18}"); // false
            Console.WriteLine();
        }

        public static void StrictementPlusPetitDemo()
        {
            Console.WriteLine("-- strictement plus petit (<) --");

            Console.WriteLine($"16 < 18 : {16 < 18}"); // true
            Console.WriteLine($"18 < 18 : {18 < 18}"); // false
            Console.WriteLine();
        }

        public static void PlusGrandOuEgalDemo()
        {
            Console.WriteLine("-- plus grand ou égal (>=) --");

            // l'égalité compte aussi
            int age = 18;
            bool estMajeur = age >= 18; // true
            Console.WriteLine($"18 >= 18 : {estMajeur}");
            Console.WriteLine();
        }

        public static void PlusPetitOuEgalDemo()
        {
            Console.WriteLine("-- plus petit ou égal (<=) --");

            int age = 12;
            bool tarifEnfant = age <= 12; // true
            Console.WriteLine($"12 <= 12 : {tarifEnfant}");
            Console.WriteLine();
        }
    }
}
