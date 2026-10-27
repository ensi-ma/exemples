namespace MaBanque;

public class Compte
{
    public Compte(int id, string nom, decimal solde)
    {
        Id = id;
        Nom = nom;
        Solde = solde;
    }
    //Methode Débiter qui retourne un booléen indiquant si le débit a été effectué avec succès
    public bool Debiter(decimal montant)
    {
        if (montant <= 0 || montant > Solde)
        {
            return false;
        }
        Solde -= montant;
        return true;
    }
    
    //methode Crediter qui retourne un booléen indiquant si le crédit a été effectué avec succès
    public bool Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            return false;
        }
        Solde += montant;
        return true;
    }
    //Methode de Virement 
    public bool Virement(
        Compte target, 
        decimal amount)
    {
        if (!this.Debiter(amount))  return false;
        target.Crediter(amount);
        return true;
    }
    
    
    //Methode Afficher qui affiche les informations du compte
    public void Afficher()
    {
        Console.WriteLine($"Id: {Id}, Nom: {Nom}, Solde: {Solde}");
    }


    public int Id { get; set; }
    public string Nom { get; set; }
    public decimal Solde { get; set; }
    

    
    
    
}