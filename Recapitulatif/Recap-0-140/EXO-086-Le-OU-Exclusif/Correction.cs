// ===================================================================================
//  CORRECTION — EXO 086 — Le OU exclusif : ^
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 2 : au départ, le client prend les deux
        bool prendDessert = true;
        bool prendCafe = true;

        // consigne 3 : ^ est vrai seulement si UN SEUL des deux est vrai
        bool menuValide = prendDessert ^ prendCafe;
        Console.WriteLine($"Menu valide : {menuValide}");

        // consigne 4 : les 4 cas
        //    dessert = true,  café = true   -> False  (les deux : interdit)
        //    dessert = true,  café = false  -> True   (dessert seul)
        //    dessert = false, café = true   -> True   (café seul)
        //    dessert = false, café = false  -> False  (ni l'un ni l'autre)
        //    (différence avec || : avec le OU normal, le cas « les deux » donnerait True)
    }
}
