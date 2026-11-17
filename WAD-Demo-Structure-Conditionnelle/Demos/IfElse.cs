namespace WAD_Demo_Structure_Conditionnelle.Demos
{
    // -- IF...ELSE --  && || ( )
    // SI la condition est vraie on fait le if, SINON on fait le else
    internal static class IfElse
    {
        public static void IfElseMajeurPeutRentrerDemo()
        {
            Console.WriteLine("-- if...else --");

            int age = 20;

            // DANS LE CAS OÙ SI mon utilisateur est majeur c'est okay
            if (age >= 18)
            {
                Console.WriteLine("Vous pouvez rentrer");
            }
            else
            {
                Console.WriteLine("Vous ne pouvez pas rentrer");
            }
            Console.WriteLine();
        }

        public static void IfAvecEtLesDeuxConditionsDoiventEtreVraiesDemo()
        {
            Console.WriteLine("-- if avec ET (&&) --");

            int age = 20;
            bool aSonDiplome = false;

            // faut être majeur ET avoir un diplôme
            // le ET en C# = &&
            // Les deux conditions doivent être vraies donc
            // il doit avoir + de 18 ans et en même temps
            // son diplôme
            if (age >= 18 && aSonDiplome)
            {
                Console.WriteLine("Entrer");
            }
            else
            {
                Console.WriteLine("Refuser"); // celle-ci : il est majeur mais n'a pas son diplôme
            }
            Console.WriteLine();
        }

        public static void IfAvecOuAuMoinsUneConditionDoitEtreVraieDemo()
        {
            Console.WriteLine("-- if avec OU (||) --");

            int age = 20;
            bool aSonDiplome = false;

            // Si l'user a soit son diplôme soit plus de 18 ans il rentre
            // en C# le OR = ||
            // soit tu as + de 18 donc tu peux rentrer
            // soit tu as ton diplôme donc tu peux rentrer
            // ou alors tu as les deux en même temps
            if (age >= 18 || aSonDiplome)
            {
                Console.WriteLine("Rentre"); // celle-ci : il est majeur, ça suffit
            }
            else
            {
                Console.WriteLine("Dégage");
            }
            Console.WriteLine();
        }

        public static void IfAvecVipEtParenthesesDemo()
        {
            Console.WriteLine("-- if avec VIP et parenthèses --");

            // Nous intégrons dans notre boîte de nuit le statut VIP
            // VIP permet de rentrer peu importe l'âge ou s'il possède son diplôme
            // S'il n'est pas VIP
            // il doit avoir les deux donc
            // il doit être majeur et avoir son diplôme
            int age = 17;
            bool aSonDiplome = false;
            bool estVip = true;

            // estVip(true) || (17 && false)
            if (estVip || (age >= 18 && aSonDiplome))
            {
                Console.WriteLine("Autoriser"); // celle-ci : il est VIP
            }
            else
            {
                Console.WriteLine("Refuser");
            }
            Console.WriteLine();
        }
    }
}
