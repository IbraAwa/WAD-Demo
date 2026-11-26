namespace LABO_1_Caisse_Enregistreuse.structures;
internal struct Vente
{
    public int NumeroTicket;
    public int NombreArticles;
    public decimal Remise;
    public decimal MontantPaye;

    public Vente(int numeroTicket, int nombreArticles, decimal remise, decimal montantPaye)
    {
        NumeroTicket = numeroTicket;
        NombreArticles = nombreArticles;
        Remise = remise;
        MontantPaye = montantPaye;
    }
}
