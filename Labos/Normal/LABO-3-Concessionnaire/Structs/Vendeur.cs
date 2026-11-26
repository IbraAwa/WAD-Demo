
namespace LABO_3_Concessionnaire.Structs;

internal struct Vendeur
{
    public int Numero;
    public string Prenom;
    public int RemiseMax;   // en %

    public Vendeur(int numero, string prenom, int remiseMax)
    {
        Numero = numero;
        Prenom = prenom;
        RemiseMax = remiseMax;
    }
}