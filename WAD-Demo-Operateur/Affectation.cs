namespace WAD_Demo_Operateur
{
    // -- AFFECTATION ET RACCOURCIS --  = += -= *= /= %=
    internal static class Affectation
    {
        public static void AffectationSimpleRangeUneValeurDemo()
        {
            Console.WriteLine("-- affectation simple (=) --");

            // le '= (égale)' range une valeur dans une variable (ce n'est PAS une comparaison)
            double total = 0;
            total = 12.50; // on remplace l'ancienne valeur
            Console.WriteLine($"total panier : {total}");
            Console.WriteLine();
        }

        public static void RaccourciPlusEgalAdditionDemo()
        {
            Console.WriteLine("-- raccourci += --");

            // les raccourcis évitent de réécrire le nom de la variable
            double total = 0;

            total += 12.50; // total = total + 12.50  -> 12,5
            total += 7.99;  // total = total + 7.99   -> 20,49
            total += 20;    // total = total + 20     -> 40,49
            Console.WriteLine($"total panier : {total}");
            Console.WriteLine();
        }

        public static void RaccourciMoinsEgalSoustractionDemo()
        {
            Console.WriteLine("-- raccourci -= --");

            double total = 40;
            total -= 5; // total = total - 5 (bon de réduction)
            Console.WriteLine($"total après bon : {total}");
            Console.WriteLine();
        }

        public static void RaccourciFoisEgalMultiplicationDemo()
        {
            Console.WriteLine("-- raccourci *= --");

            // remise de 10 %
            double total = 40;
            total *= 0.9; // total = total * 0.9
            Console.WriteLine($"total après remise : {total}");
            Console.WriteLine();
        }

        public static void RaccourciDiviseEgalDivisionDemo()
        {
            Console.WriteLine("-- raccourci /= --");

            // on partage l'addition entre 4 amis
            double total = 40;
            total /= 4; // total = total / 4
            Console.WriteLine($"chacun paie : {total}");
            Console.WriteLine();
        }

        public static void RaccourciModuloEgalResteDemo()
        {
            Console.WriteLine("-- raccourci %= --");

            // 130 minutes de livraison, combien de minutes en plus des heures pleines ?
            int minutes = 130;
            minutes %= 60; // minutes = minutes % 60 -> 10 (2h et 10 min)
            Console.WriteLine($"minutes restantes : {minutes}");
            Console.WriteLine();
        }

        public static void PiegeDoubleImprecisAvecLesRaccourcisDemo()
        {
            Console.WriteLine("-- piège : le double n'est pas précis --");

            double total = 40.49;
            total *= 0.9;
            total -= 5;
            Console.WriteLine($"total : {total}");
            // affiche 31,441000000000003 au lieu de 31,441
            // rappel : le double n'est pas précis, pour de l'argent on préfère le decimal
            Console.WriteLine();
        }

        public static void RaccourciPlusEgalAvecStringDemo()
        {
            Console.WriteLine("-- raccourci += avec un string --");

            // le += marche aussi avec les string
            string listeCourse = "pain";
            listeCourse += ", lait"; // listeCourse = listeCourse + ", lait"
            Console.WriteLine(listeCourse);
            Console.WriteLine();
        }
    }
}
