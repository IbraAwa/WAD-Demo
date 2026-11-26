using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABO_1_Caisse_Enregistreuse.Methodes;

internal struct Demande
{
    public static int demandeEntierEntre(string question, int minimum, int maximum)
    {
        int nombreRecu = 0;

        do
        {
            nombreRecu = DemanderEntier(question);
        } while (nombreRecu < minimum || nombreRecu > maximum);

        return nombreRecu;
    }

    public static int DemanderEntier(string question)
    {
        Console.WriteLine(question);
        int nombreVoulu = 0;
        bool estConverti = int.TryParse(Console.ReadLine(), out nombreVoulu);
        bool continuer = estConverti ? false : true;

        while (continuer)
        {
            Console.WriteLine();
            Console.WriteLine("Ce n'est pas un nombre valide, recommence :");
            Console.WriteLine(question);
            estConverti = int.TryParse(Console.ReadLine(), out nombreVoulu);

            continuer = estConverti ? false : true; // Si converti on ne continue pas sinon on continue
        }

        return nombreVoulu;
    }


    public static decimal DemanderMontant(string question)
    {
        Console.WriteLine(question);
        bool estConverti = decimal.TryParse(Console.ReadLine(), out decimal montantDonnerClient);

        // !estconverti -> c'est mieux
        while (estConverti == false)
        {
            Console.WriteLine("Donner moi un montant valide");
            estConverti = decimal.TryParse(Console.ReadLine(), out montantDonnerClient);
        }

        return montantDonnerClient;
    }
}
