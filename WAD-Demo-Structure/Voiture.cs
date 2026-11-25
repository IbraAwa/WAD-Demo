namespace WAD_Demo_Structure
{
    // struct = le PLAN de ma voiture (le gros carton)
    // chaque objet Voiture créé avec ce plan aura une Marque et une Couleur (les petits cartons)
    internal struct Voiture
    {
        // Propriété (un petit carton dans le gros carton)
        // public = on peut y accéder depuis l'extérieur (Program.cs, les démos...)
        // nom en PascalCase (majuscule au début), contrairement aux variables (camelCase)
        public string Marque;

        // Propriété
        public string Couleur;

        // attention : techniquement 'public string Marque;' est un CHAMP (field)
        // une vraie propriété s'écrit 'public string Marque { get; set; }'
        // on les verra avec les classes, pour l'instant ça s'utilise de la même manière

        // Construire votre objet = le CONSTRUCTEUR
        // même nom que la struct, pas de type de retour (même pas void)
        // oblige le dev à construire l'objet d'une certaine manière (ici avec une marque ET une couleur)
        // marque (paramètre, camelCase) -> Marque (propriété, PascalCase)
        public Voiture(string marque, string couleur)
        {
            Marque = marque;
            Couleur = couleur;
        }
    }
}
