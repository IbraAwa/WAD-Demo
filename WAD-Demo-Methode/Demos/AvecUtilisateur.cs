namespace WAD_Demo_Methode.Demos
{
    // -- AVEC L'UTILISATEUR --
    // on mélange tout : saisie + TryParse + boucles + méthodes réutilisables
    // l'idée : le code qui se répète (demander un nombre) est écrit UNE fois dans une méthode
    internal static class AvecUtilisateur
    {
        // ----- les méthodes réutilisables -----

        // une fonction qui redemande tant que l'utilisateur ne tape pas un nombre
        private static int DemanderEntier(string question)
        {
            Console.Write(question);
            int nombre;
            while (!int.TryParse(Console.ReadLine(), out nombre))
            {
                Console.Write("ce n'est pas un nombre valide, recommencez : ");
            }

            return nombre;
        }

        private static bool Diviser(int a, int b, out decimal resultat)
        {
            resultat = 0m;
            if (b == 0)
            {
                return false;
            }

            resultat = (decimal)a / b;
            return true;
        }

        private static string Saluer(string prenom, string formulePolitesse = "Bonjour")
        {
            return $"{formulePolitesse} {prenom}";
        }

        // ----- les démos -----

        public static void AdditionnerDeuxNombresSaisisDemo()
        {
            Console.WriteLine("-- additionner deux nombres saisis --");

            // sans méthode, on aurait dû écrire DEUX fois la boucle while + TryParse
            int premier = DemanderEntier("premier nombre : ");
            int second = DemanderEntier("second nombre : ");

            Console.WriteLine($"{premier} + {second} = {premier + second}");
            Console.WriteLine();
        }

        public static void DiviserDeuxNombresSaisisDemo()
        {
            Console.WriteLine("-- diviser deux nombres saisis (out) --");

            int a = DemanderEntier("nombre à diviser : ");
            int b = DemanderEntier("diviser par : ");

            if (Diviser(a, b, out decimal resultat))
            {
                Console.WriteLine($"{a} / {b} = {resultat}");
            }
            else
            {
                Console.WriteLine("impossible de diviser par 0 !");
            }
            Console.WriteLine();
        }

        public static void SaluerAvecUneFormuleFacultativeDemo()
        {
            Console.WriteLine("-- saluer avec une formule facultative --");

            Console.Write("Votre prénom : ");
            string prenom = Console.ReadLine() ?? "";

            Console.Write("Votre formule de politesse (laisser vide pour \"Bonjour\") : ");
            string? formule = Console.ReadLine();

            // si l'utilisateur n'a rien tapé -> on n'envoie pas la formule, la valeur par défaut est utilisée
            if (string.IsNullOrWhiteSpace(formule))
            {
                Console.WriteLine(Saluer(prenom));
            }
            else
            {
                Console.WriteLine(Saluer(prenom, formule));
            }
            Console.WriteLine();
        }
    }
}
