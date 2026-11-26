using LABO_3_Concessionnaire.Enums;
using LABO_3_Concessionnaire.Structs;

namespace LABO_3_Concessionnaire.Utils;

internal struct AjouterVoitureQuestion
{
    // Static : on appelle la méthode sans créer d'objet AjouterVoitureQuestion
    public static Plaque DemanderPlaque(Dictionary<string, Voiture> stocks)
    {
        string? plaque = null;
        Plaque? checkPlaque = null;
        bool isInvalidPlaque = true;
        while (isInvalidPlaque)
        {
            Console.WriteLine();
            Console.Write("Plaque ? : ");
            plaque = Console.ReadLine();

            // On valide le format d'abord. Si plaque est null/vide, checkPlaque reste null
            checkPlaque = string.IsNullOrWhiteSpace(plaque) ? null : Plaque.Creer(plaque);

            // ContainsKey SEULEMENT si checkPlaque OK, sinon plaque.ToUpper() planterait sur un null
            bool plaqueDejaExistante = checkPlaque is not null && stocks.ContainsKey(plaque!.ToUpper());
            if (plaqueDejaExistante) Console.WriteLine("Plaque déjà existante dans le concessionnaire");

            isInvalidPlaque = checkPlaque is null || plaqueDejaExistante;
        }

        // ! car on ne sort de la boucle que si checkPlaque est valide
        return checkPlaque!.Value;
    }

    public static string DemanderString(string question)
    {
        // Redemande tant que la réponse est vide ou blanche
        string? reponse = null;
        while (string.IsNullOrWhiteSpace(reponse))
        {
            Console.WriteLine();
            Console.Write(question);
            reponse = Console.ReadLine();
        }

        return reponse;
    }

    // Réutilisable : année (min/max) ET kilométrage (min 0, pas de max)
    // paramètre facultative
    public static int DemanderInt(string question, int max, int min = 0)
    {
        int valeur = 0;
        bool invalide = true;
        while (invalide)
        {
            Console.WriteLine();
            Console.Write(question);
            bool estConverti = int.TryParse(Console.ReadLine(), out int converti);

            if (estConverti && converti >= min && converti <= max)
            {
                valeur = converti;
                invalide = false;
            }
            else
            {
                // message propre selon qu'il y a une borne max ou non
                string borne = max == int.MaxValue ? $">= {min}" : $"entre {min} et {max}";
                Console.WriteLine($"La valeur doit être un nombre entier {borne}");
            }
        }

        return valeur;
    }

    // Réutilisable : prix d'achat (strict > min) ET prix de vente (>= min)
    public static decimal DemanderDecimal(string question,bool strict, decimal min = 0.00m)
    {
        decimal valeur = 0m;
        bool invalide = true;
        while (invalide)
        {
            Console.WriteLine();
            Console.Write(question);
            bool estConverti = decimal.TryParse(Console.ReadLine(), out decimal converti);

            // strict true -> il faut > min ; strict false -> >= min suffit
            bool respecteMin = strict ? converti > min : converti >= min;

            if (estConverti && respecteMin)
            {
                valeur = converti;
                invalide = false;
            }
            else
            {
                string condition = strict ? $"strictement supérieur à {min}" : $"supérieur ou égal à {min}";
                Console.WriteLine($"La valeur doit être un nombre {condition}");
            }
        }

        return valeur;
    }

    public static Carburant DemanderCarburant()
    {
        Carburant carburant = default;
        bool invalide = true;
        while (invalide)
        {
            Console.WriteLine();
            Console.Write("Carburant (Essence, Diesel, Hybride, Electrique) ? : ");
            string? saisie = Console.ReadLine();

            // TryParse convertit le texte en enum, IsDefined bloque les nombres ("999")
            bool valide = Enum.TryParse(saisie, ignoreCase: true, out Carburant converti)
                          && Enum.IsDefined(typeof(Carburant), converti);
            if (valide)
            {
                carburant = converti;
                invalide = false;
            }
            else
            {
                Console.WriteLine("Carburant invalide");
            }
        }

        return carburant;
    }
}