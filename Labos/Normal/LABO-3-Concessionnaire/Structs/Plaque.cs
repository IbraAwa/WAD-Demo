using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABO_3_Concessionnaire.Structs;

internal struct Plaque
{
    public string Immatriculation;    // 1-ABC-123
    public char Indice;      // 1
    public string Lettres;   // ABC
    public string Chiffres;  // 123

    public Plaque(string valeur, char indice, string lettres, string chiffres)
    {
        Immatriculation = valeur;
        Indice = indice;
        Lettres = lettres;
        Chiffres = chiffres;
    }

    public static Plaque? Creer(string plaque)
    {
        if (string.IsNullOrWhiteSpace(plaque) || plaque.Length != 9)
        {
            MessageErreurPlaque("La plaque doit faire exactement 9 caractères au format 1-ABC-123");
            return null;
        }

        // Appel totu les validateur
        // envoyé toute les erreurs en même temps
        // et non une erreur un à un 
        // pourquoi ? 
        // permet à l'utilisateur de corriger bug en une fois 
        // meilleur UX

        bool indiceValider = IndiceValid(plaque[0]);
        bool premierSeparateurValider = SeparateurValid(plaque[1]);
        bool lettresValider = lettreValid(plaque[2], plaque[3], plaque[4]);
        bool secondSeparateurValider = SeparateurValid(plaque[5]);
        bool chiffresValider = chiffreValid(plaque[6], plaque[7], plaque[8]);

        if (!indiceValider || 
            !premierSeparateurValider || 
            !lettresValider || 
            !secondSeparateurValider || 
            !chiffresValider)
        {
            return null;
        }

        // 1 - ABC - 123
        return new Plaque(
            plaque,
            plaque[0],
            plaque.Substring(2, 3),
            plaque.Substring(6, 3)
        );
    }


    // METHODE PRIVATE
    // CAR UNIQUEMENT LA STRUCT utilisera ses méthodes
    // ses méthodes ne serveut que a struct plaque
    private static bool IndiceValid(char indice)
    {
        if (char.IsDigit(indice))
        {
            bool estConverti = int.TryParse(indice.ToString(), out int indiceInt);
            if (estConverti)
            {
                if (indiceInt < 1 || indiceInt > 9)
                {
                    MessageErreurPlaque("Le début de plaque (l'indice) est invalide" +
                        $"il doit être entre 1 et 9 pour l'instant l'indice est {indiceInt}");
                    return false;
                }
            }
            else
            {
                MessageErreurPlaque($"le début de la plaque (l'indice) est invalide" +
                    $"il doit être un digit pour l'instant c'est : {indice}");
                return false;
            }
        }
        else
        {
            return false;
        }

        return true;
    }

    private static bool SeparateurValid(char separateur)
    {
        if (separateur != '-')
        {
            MessageErreurPlaque("Les séparateurs doivent être des tirets '-'" +
                $" pour l'instant c'est : {separateur}");
            return false;
        }

        return true;
    }

    private static bool lettreValid(char lettreUn, char lettreDeux, char lettreTrois)
    {
        if (!char.IsLetter(lettreUn))
        {
            MessageErreurPlaque("La première lettre de la partie (lettres) de la plaque est mauvaise" +
                $"il doit être uniquement composé de lettre d'alphabet et la premiere lettre est {lettreUn}");
            return false;
        }

        if (!char.IsLetter(lettreDeux))
        {
            MessageErreurPlaque("La deuxième lettre de la partie (lettres) de la plaque est mauvaise" +
                $"il doit être uniquement composé de lettre d'alphabet et la deuxième lettre est {lettreDeux}");
            return false;
        }

        if (!char.IsLetter(lettreTrois))
        {
            MessageErreurPlaque("La troisième lettre de la partie (lettres) de la plaque est mauvaise" +
                $"il doit être uniquement composé de lettre d'alphabet et la troisième lettre est {lettreTrois}");
            return false;
        }

        return true;
    }

    private static bool chiffreValid(char chiffreUn, char chiffreDeux, char chiffreTrois)
    {
        if (!char.IsDigit(chiffreUn))
        {
            MessageErreurPlaque("Le premier chiffre de la plaque est mauvais" +
                $"il doit être un digit et pour l'instant c'est : {chiffreUn}");
            return false;
        }

        if (!char.IsDigit(chiffreDeux))
        {
            MessageErreurPlaque("Le deuxième chiffre de la plaque est mauvais" +
                $"il doit être un digit et pour l'instant c'est : {chiffreDeux}");
            return false;
        }

        if (!char.IsDigit(chiffreTrois))
        {
            MessageErreurPlaque("Le troisième chiffre de la plaque est mauvais" +
                $"il doit être un digit et pour l'instant c'est : {chiffreTrois}");
            return false;
        }

        return true;
    }

    private static void MessageErreurPlaque(string message)
    {
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("!!! Plaque non conforme !!!");
        Console.WriteLine(message);
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
    }
}