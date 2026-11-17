namespace WAD_Demo.Demos
{
    // -- TYPE VALEUR OU TYPE RÉFÉRENCE --
    // type valeur     (int, double, bool...)  : la variable contient directement la valeur
    // type référence  (List, class...)        : la variable contient l'adresse où l'objet est rangé en mémoire
    internal static class TypeValeurEtReference
    {
        public static void TypeValeurCompareLesValeursDemo()
        {
            Console.WriteLine("-- type valeur --");

            // un type qui est de type valeur
            // quand on compare les deux
            // le langage va comparer les deux valeurs
            int ageMarco = 20;
            int ageLea = 20;

            if (ageMarco == ageLea)
            {
                Console.WriteLine("les âges sont égaux");
            }
            Console.WriteLine();
        }

        public static void TypeReferenceCompareLAdresseDemo()
        {
            Console.WriteLine("-- type référence --");

            // un type référence : quand on compare les deux
            // le langage compare les adresses, PAS le contenu
            // ici deux listes de courses avec le même contenu, mais rangées à deux endroits différents
            List<string> listeCourseMarco = new List<string>
            {
                "pain", "lait", "oeufs"
            };

            List<string> listeCourseLea = new List<string>
            {
                "pain", "lait", "oeufs"
            };

            if (listeCourseMarco == listeCourseLea)
            {
                Console.WriteLine("la liste est pareille");
            }
            else
            {
                Console.WriteLine("la liste n'est pas pareille"); // celle-ci !
            }
            Console.WriteLine();
        }

        public static void MettreUneReferenceDansUneAutreReferenceDemo()
        {
            Console.WriteLine("-- mettre une référence dans une autre --");

            // mettre une référence dans une autre référence
            // on ne copie pas la liste, on copie son adresse
            List<string> listeCourse = new List<string>
            {
                "pain", "lait", "oeufs"
            };

            List<string> listeCourseDuColoc = listeCourse;

            if (listeCourse == listeCourseDuColoc)
            {
                Console.WriteLine("c'est pareil"); // celle-ci ! même adresse
            }
            else
            {
                Console.WriteLine("ce n'est pas pareil");
            }
            Console.WriteLine();
        }

        public static void PiegeModifierUneReferenceModifieLesDeuxDemo()
        {
            Console.WriteLine("-- piège : les deux variables partagent la même liste --");

            List<string> listeCourse = new List<string>
            {
                "pain", "lait", "oeufs"
            };

            List<string> listeCourseDuColoc = listeCourse;

            // le coloc ajoute du café sur SA liste...
            listeCourseDuColoc.Add("café");

            // ... mais c'est la même liste, donc ma liste a changé aussi
            Console.WriteLine($"ma liste : {string.Join(", ", listeCourse)}"); // pain, lait, oeufs, café
            Console.WriteLine();
        }
    }
}
