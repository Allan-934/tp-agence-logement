public class Logement 
{
    private protected string reference; 
    private protected string adresse;
    private protected int surface;
    private protected double loyerBase;
    private protected bool disponible; 

    // Constructeur pour initialiser tous les attributs avec validation
    public Logement(string reference, string adresse, int surface, double loyerBase, bool disponible)
    {
        if (surface <= 0) 
            throw new ArgumentException("La surface doit être strictement positive.");
        
        if (loyerBase < 0) 
            throw new ArgumentException("Le loyer de base ne peut pas être négatif.");

        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
    }

    // Méthode pour calculer le loyer (Logique de base)
    public virtual double CalculerLoyer()
    {
        return loyerBase*surface; // Retourne le loyer calculé
    }

    // Méthode pour afficher les informations du logement
    public virtual void Afficher()
    {
        Console.WriteLine($"Référence : {reference}");
        Console.WriteLine($"Adresse : {adresse}");
        Console.WriteLine($"Surface : {surface} m²");
        Console.WriteLine($"Loyer : {CalculerLoyer():F2} €");
        Console.WriteLine($"Disponible : {(disponible ? "Oui" : "Non")}");
    }

    // Redéfinition de ToString pour une description rapide
    public override string ToString()
    {
        return $"Logement {reference} ({surface} m²) - {CalculerLoyer():F2} €";  
    }
}