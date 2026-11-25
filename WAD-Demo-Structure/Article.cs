namespace WAD_Demo_Structure
{
    // struct Article : un article d'un magasin
    // une struct peut mélanger plusieurs types (string, int, bool, double...)
    // ici pas de constructeur : on remplit les propriétés avec { } à la création
    internal struct Article
    {
        // le nom de l'article (ex : "Pomme")
        public string Nom;

        // fruit, légume, snack ou autre...
        public string Categorie;

        // la quantité disponible en stock
        public int Stock;

        public Price Prix;

        public Article(string nom, string categorie, int stock, Price prix)
        {
            Nom = nom;
            Categorie = categorie;
            Stock = stock;
            Prix = prix;
        }
    }
}
