using LABO_1_Caisse_Enregistreuse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABO_1_Caisse_Enregistreuse.structures;

internal struct Produit
{
    public int Code;
    public string Nom;

    public decimal Prix;

    public Categorie Categorie;

    public Produit(int code, string nom, decimal prix, Categorie categorie)
    {
        Code = code;
        Nom = nom;
        Prix = prix;
        Categorie = categorie;
    }
}
