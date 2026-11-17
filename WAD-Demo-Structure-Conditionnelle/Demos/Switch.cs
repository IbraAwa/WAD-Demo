namespace WAD_Demo_Structure_Conditionnelle.Demos
{
    // -- SWITCH --  case / break / default  et  switch expression
    // exemple connu : le numéro du jour de la semaine
    internal static class Switch
    {
        public static void SwitchJourDeLaSemaineDemo()
        {
            Console.WriteLine("-- switch --");

            int jour = 4;

            // moins verbeux que le if else
            // mais attention
            // pas de condition complexe dans les case
            // il compare une valeur à une autre
            // break = on sort du switch
            // default = aucun case ne correspond (comme le else)
            switch (jour)
            {
                case 1:
                    Console.WriteLine("Lundi");
                    break;
                case 2:
                    Console.WriteLine("Mardi");
                    break;
                case 3:
                    Console.WriteLine("Mercredi");
                    break;
                case 4:
                    Console.WriteLine("Jeudi");
                    break;
                case 5:
                    Console.WriteLine("Vendredi");
                    break;
                case 6:
                    Console.WriteLine("Samedi");
                    break;
                case 7:
                    Console.WriteLine("Dimanche");
                    break;
                default:
                    Console.WriteLine("Jour de la semaine incorrect");
                    break;
            }
            Console.WriteLine();
        }

        public static void SwitchExpressionRangeUneValeurDemo()
        {
            Console.WriteLine("-- switch expression --");

            int jour = 4;

            // affecte une valeur dans 'jourString'
            // selon une condition
            // _ = tous les autres cas (comme le default)
            string jourString = jour switch
            {
                1 => "lundi",
                2 => "mardi",
                3 => "mercredi",
                4 => "jeudi",
                5 => "vendredi",
                6 => "samedi",
                7 => "dimanche",
                _ => "Jour incorrect"
            };
            Console.WriteLine($"le jour {jour} est un {jourString}");
            Console.WriteLine();
        }
    }
}
