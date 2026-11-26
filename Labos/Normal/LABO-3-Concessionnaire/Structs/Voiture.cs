using LABO_3_Concessionnaire.Enums;
using System.Text;

namespace LABO_3_Concessionnaire.Structs;

internal struct Voiture
{
    public Plaque Plaque;
    public string PlaqueMajuscule;
    public string Marque;
    public string Modele;
    public int Annee;
    public int Kilometrage;
    public decimal PrixAchat;
    public decimal PrixVente;
    public Carburant Carburant;

    // Pas dans le constructeur : valeur par défaut false
    // Pourquoi ? une voiture qu'on crée n'est jamais vendue ni reprise au départ
    // on les passera à true plus tard (vente / reprise)
    public bool EstVendue;
    public bool EstReprise;

    public Voiture(Plaque plaque, string plaqueMajuscule, string marque, string modele, int annee, int kilometrage, decimal prixAchat, decimal prixVente, Carburant carburant)
    {
        Plaque = plaque;
        PlaqueMajuscule = plaqueMajuscule;
        Marque = marque;
        Modele = modele;
        Annee = annee;
        Kilometrage = kilometrage;
        PrixAchat = prixAchat;
        PrixVente = prixVente;
        Carburant = carburant;
    }

    public static Voiture? Creer(string plaque,
        string marque,
        string modele,
        int annee,
        int kilometrage,
        decimal prixAchat,
        decimal prixVente,
        string carburant)
    {
        Plaque? plaqueCheck = Plaque.Creer(plaque);
        if (plaqueCheck is null)
        {
            Console.WriteLine("Problème avec la plaque, voiture non créée");
            return null;
        }

        // TryParse : convertit le texte en enum (ex "Essence" -> Carburant.Essence), renvoie false si impossible.
        // ignoreCase: true -> "essence" passe aussi. Le résultat part dans le out carburantEnum.
        // Piège : TryParse accepte les nombres ("999" -> true), donc une valeur qui n'existe pas.
        // IsDefined vérifie que la valeur existe vraiment dans l'enum -> bloque le "999".
        // && : il faut que la conversion marche ET que le résultat soit une vraie valeur.
        bool validCarburant = Enum.TryParse(carburant, ignoreCase: true, out Carburant carburantEnum)
                              && Enum.IsDefined(typeof(Carburant), carburantEnum);
        if (!validCarburant)
        {
            Console.WriteLine($"Le carburant {carburant} est inexistant, veuillez mettre un carburant valide (voir enum Carburant)");
            return null;
        }

        return new Voiture(
            plaqueCheck.Value,
            plaque.ToUpper(),
            marque,
            modele,
            annee,
            kilometrage,
            prixAchat,
            prixVente,
            carburantEnum
        );
    }
}