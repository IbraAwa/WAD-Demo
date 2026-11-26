using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABO_1_Caisse_Enregistreuse.Methodes;

internal class Calcule
{
    public static decimal CalculerRemise(ref decimal total)
    {
        Console.WriteLine($"Total base : {total:N2}");
        decimal remise = 0m;

        if (total > 50)
        {
            Console.WriteLine("Remise 10%");
            remise = total * 0.10m;
        }
        else if (total > 20)
        {
            Console.WriteLine("Remise 5%");
            remise = total * 0.05m;
        }

        total -= remise;

        Console.WriteLine($"Remise : {remise:N2}");
        Console.WriteLine($"A PAYER : {total:N2}");

        return remise;
    }
}
