namespace exemple;

// Définition d'une classe
public class Personne
{
    // Champs privés
    private string nom;
    private int age;
    // Propriétés
    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value >= 0 ? value : 0; }
    }
    // Constructeur
    public Personne(string nom, int age)
    {
        this.nom = nom;
        this.age = age;
    }
    // Méthodes
    public void SePresenter()
    {
        Console.WriteLine($"Je suis {nom} et j'ai {age} ans.");
    }

    public virtual void Travailler()
    {
        Console.WriteLine($"{nom} travaille.");
    }
}


